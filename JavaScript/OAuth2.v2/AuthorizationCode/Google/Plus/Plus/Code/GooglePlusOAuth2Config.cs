﻿namespace Plus.Code
{
    public class GooglePlusOAuth2Config : OAuth2Config
    {
        public override string AuthorizationServerBaseUrl 
            => "https://accounts.google.com/o/oauth2/v2/auth";

        public override string AccessTokenBaseUrl =>
            "https://www.googleapis.com/oauth2/v4/token";
        public override string ResourceServerBaseUrl 
            => "https://www.googleapis.com/plus/v1/people/me?";
    }
}