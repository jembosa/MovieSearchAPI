using RestSharp;

namespace MovieAPI.Models
{
    public class MovieDAL
    {
        public static Movie GetMovie(string Title)
        {
            string url = $@"http://www.omdbapi.com/?t={Title}";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddParameter("apikey", "1de70cac"); // You'll need to sign up for an OMDB API key

            Movie output = client.Get<Movie>(request);

            return output;
        }
    }

}
