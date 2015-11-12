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
    afishas: ko.observableArray()
}

var modelMovieDetailsComments = {
    comments: ko.observableArray()
}

var modelCinemaAfisha = {
    cinemas: ko.observableArray()
}

function movieDetails(item) {
    ko.cleanNode($('#MovieDetailsMain')[0]);
    ko.cleanNode($('#MovieDetailsPhotoes')[0]);
    ko.cleanNode($('#MovieDetailsAfishas')[0]);
    ko.cleanNode($('#MovieDetailsComments')[0]);
    ko.cleanNode($('#MovieDetailsReview')[0]);

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

            //Adding movie photos
            for (var i = 0; i < data.photos.length; i++) {
                modelMovieDetailsPhotoes.photoes.push(data.photos[i]);                
            }
            ko.applyBindings(modelMovieDetailsPhotoes, document.getElementById('MovieDetailsPhotoes'));

            //Adding movie afisha
            for (var i = 0; i < data.afisha.length; i++) {
                modelMovieDetailsAfisha.afishas.push(data.afisha[i]);                
            }
            ko.applyBindings(modelMovieDetailsAfisha, document.getElementById('MovieDetailsAfishas'));

            //Adding movie comments
            for (var i = 0; i < data.comments.length; i++) {
                modelMovieDetailsComments.comments.push(data.comments[i]);
            }
            ko.applyBindings(modelMovieDetailsComments, document.getElementById('MovieDetailsComments'));

            //Adding movie review
            var modelMovieDetailsReview = {
                intro: data.review.intro
            }
            ko.applyBindings(modelMovieDetailsReview, document.getElementById('MovieDetailsReview'));

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

function cinemaDetails(item) {
    sendRequest("cinema", GET, function (data) {
        var modelCinema = {
            name: data.cinema.name,
            description: data.cinema.description.replace(/\n/g, '<br />'),
            address: data.cinema.city + ", " + data.cinema.address,
            dinner: "C " + data.cinema.dinner_from + ", до " + data.cinema.dinner_to,
            email: data.cinema.email,
            guides: data.cinema.guides,
            phones: data.cinema.phone,
            website: data.cinema.website
        }
        ko.applyBindings(modelCinema, document.getElementById('CinemaBlock'));

        //Cinema afisha
        for (var i = 0; i < data.afisha.length; i++) {
            modelCinemaAfisha.cinemas.push(data.afisha[i]);
        }
        ko.applyBindings(modelCinemaAfisha, document.getElementById('CinemaAfisha'));

    }, item.cinema_id);
    
    $('.moviesBlock > div').removeClass('active');    
    $('#Cinema').addClass('active');
}

$(document).ready(function () {
    $('.tabs li').click(function () {
        $('.tabs li').removeClass('active').eq($(this).index()).addClass('active');
        $('.mainBlock > div').removeClass('active').eq($(this).index()).addClass('active');        
    });
    mainMovies();
   
});