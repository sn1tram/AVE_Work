using MovHubDb.Model;
using Newtonsoft.Json;
using System;
using System.Net;

namespace MovHubDb
{
    public class TheMovieDbClient
    {

        /// <summary>
        /// e.g.: https://api.themoviedb.org/3/search/movie?api_key=bcaedc919eaf3c101a1d8186649c6fa4&query=war%20games
        /// </summary>
        public MovieSearchItem[] Search(string title, int page)
        {
            WebClient client = new WebClient();
            string url = "https://api.themoviedb.org/3/search/movie?api_key=bcaedc919eaf3c101a1d8186649c6fa4";
            url += "&query=" + title.Replace(" ", "%");
            string body = client.DownloadString(url);
            MovieSearch movieSearch = (MovieSearch)JsonConvert.DeserializeObject(body, typeof(MovieSearch));
            return movieSearch.Results;
        }

        /// <summary>
        /// e.g.: https://api.themoviedb.org/3/movie/508?api_key=bcaedc919eaf3c101a1d8186649c6fa4
        /// </summary>
        public Movie MovieDetails(int id) {
            WebClient client = new WebClient();
            string apiKey = "?api_key=bcaedc919eaf3c101a1d8186649c6fa4";
            string url = "https://api.themoviedb.org/3/movie/" + id + apiKey;
            string body = client.DownloadString(url);
            Movie movie = (Movie)JsonConvert.DeserializeObject(body, typeof(Movie));
            return movie;
        }

        /// <summary>
        /// e.g.: https://api.themoviedb.org/3/movie/508/credits?api_key=bcaedc919eaf3c101a1d8186649c6fa4
        /// </summary>
        public CreditsItem[] MovieCredits(int id) {
            return new CreditsItem[0];
        }

        /// <summary>
        /// e.g.: https://api.themoviedb.org/3/person/3489?api_key=bcaedc919eaf3c101a1d8186649c6fa4
        /// </summary>
        public Person PersonDetais(int actorId)
        {
            return new Person();
        }

        /// <summary>
        /// e.g.: https://api.themoviedb.org/3/person/3489/movie_credits?api_key=bcaedc919eaf3c101a1d8186649c6fa4
        /// </summary>
        public MovieSearchItem[] PersonMovies(int actorId) {
            return new MovieSearchItem[0];
        }
    }
}
