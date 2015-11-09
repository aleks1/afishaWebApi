const GET = "get";
const POST = "post";

function sendRequest(url, type, callbackFunction,addData) {
    $.ajax({
        url: "api/" + url,
        method: type,
        success: callbackFunction,
        data: { id: addData }
    });
}

var modelMovieDetailsPhotoes = {
    photoes: ko.observableArray()
}

var modelMovieDetailsAfisha = {
    shows: ko.observableArray()
}

var modelMovieDetailsCinema = {
    shows: ko.observableArray(),    
}

function movieDetails(item) {
    sendRequest("movie", GET, function (data) {
            //Main info
            var modelMovieDetails = {
                name: data.name,
                actors: data.actors,
                country:data.country,
                date_premiere: data.date_premiere,
                description:data.description,
                director:data.director, 
                duration:data.duration,
                format:data.format,
                genre:data.genre,
                image_big_path:data.image_big_path,
                imdb_rating:data.imdb_rating,
                is_recommended:data.is_recommended,
                movie_id:data.movie_id,
                original:data.original,
                permalink:data.permalink,
                production:data.production,
                rating:data.rating,
                rating_code:data.rating_code,
                rating_notice:data.rating_notice,
                review:data.review,
                trailer_moveruz:data.trailer_moveruz,
                url:data.url,
                voices: data.voices,
                id: data.movie_id
            }
            ko.applyBindings(modelMovieDetails, document.getElementById('MovieDetailsMain'));

            //Adding movie photoes
            for (var i = 0; i < data.photos.length; i++) {
                modelMovieDetailsPhotoes.photoes.push(data.photos[i]);
                console.log(data.photos[i]);
            }
            ko.applyBindings(modelMovieDetailsPhotoes, document.getElementById('MovieDetailsPhotoes'));
            
            $('.moviesBlock > div').removeClass('active');
            $('#MovieDetails').addClass('active');
        },
        item.movie_id
    );
}

function mainMovies() {
    sendRequest("movie", GET, function (data) {
        var modelMovies = {
            movies: ko.observableArray()
        }
        for (var i = 0; i < data.length; i++) {
            modelMovies.movies.push(data[i]);
        }
        ko.applyBindings(modelMovies, document.getElementById('MoviesBlock'));
    });
    $('#MoviesBlock').addClass('active');
}

$(document).ready(function () {
    $('.tabs li').click(function () {
        $('.tabs li').removeClass('active').eq($(this).index()).addClass('active');
        $('.mainBlock > div').removeClass('active').eq($(this).index()).addClass('active');        
    });
    mainMovies();
   
});