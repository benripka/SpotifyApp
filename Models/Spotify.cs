using System;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;

namespace SpotifyApp.Models
{
    public class Spotify
    {
        private static SpotifyWebAPI spotify;
        private static string clientId = "a2bc2d784487409a82a9551539137158";
        private static string clientSecret = "915e5883f7744ace8bbac83be35d915c";

        public void Setup()
        {
            Task<Token> tokenTask = getToken();
            Token token = tokenTask.Result;
            spotify = new SpotifyWebAPI() {TokenType = token.TokenType, AccessToken = token.AccessToken};
        }
        private async Task<Token> getToken()
        {
            CredentialsAuth auth = new CredentialsAuth(clientId, clientSecret);
            Token token = await auth.GetToken();
            return token;
        }

        public FullArtist GetArtistByName(string name)
        {
            SearchItem item = spotify.SearchItems(name, SearchType.Artist);
            return item.Artists.Items[0];
        }

        public string getSigninUrl()
        {
            return prepareUserAuthRequest();
        }
        public string prepareUserAuthRequest()
        {
            string encodedScopes = encodeScopes("user-read-private user-read-email");
            string encodedRedirectUri = encodeUri("https://docs.microsoft.com/en-us/dotnet");
            string request = "https://accounts/spotify.com/authorize?response_type=token&client_id="+clientId+"&scope="+ encodedScopes + "&redirect_uri=" + encodedRedirectUri;
            return request;
        }
        private string encodeScopes(string scopes)
        {   
            string urlEncodedscopes = System.Web.HttpUtility.UrlEncode(scopes);
            return Uri.EscapeDataString(Uri.EscapeUriString(urlEncodedscopes));
        }

        private string encodeUri(string uri)
        {
            return Uri.EscapeDataString(Uri.EscapeUriString(uri));
        }
    }
}