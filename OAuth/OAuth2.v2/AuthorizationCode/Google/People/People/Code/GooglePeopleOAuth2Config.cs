﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace People.Code
{
    public class GooglePeopleOAuth2Config : OAuth2Config
    {
        public override string AuthorizationServerBaseUrl
            => "https://accounts.google.com/o/oauth2/v2/auth";

        public override string AccessTokenBaseUrl =>
            "https://www.googleapis.com/oauth2/v4/token";
        public override string ResourceServerBaseUrl
            => "https://people.googleapis.com/v1/people/me?personFields=names%2CemailAddresses";

        public virtual async Task<GooglePeopleAPIData> GetDataAsync(string fields)
        {
            if (string.IsNullOrEmpty(this.AccessTokenResult.AccessToken))
            {
                throw new Exception("Access token missing. Cannot get data.");
            }

            var parameters = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(fields))
            {
                this.Fields = fields;
                parameters.Add("fields", this.Fields);
            }

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", this.AccessTokenResult.AccessToken);

                var url = this.MakeUrlWithQueryString(this.ResourceServerBaseUrl, parameters);

                string json = null;

                try
                {
                    json = await client.GetStringAsync(url);
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.ToString());
                    Debugger.Break();
                    throw ex;
                }

                try
                {
                    var googlePlusApiData = JsonConvert.DeserializeObject<GooglePeopleAPIData>(json);

                    return googlePlusApiData;
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.ToString());
                    Debugger.Break();
                    throw ex;
                }
            }
        }
    }
}