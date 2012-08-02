using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using RestSharp;
using RestSharp.Deserializers;

namespace PersonPhoneApp
{
    public class PersonsRestClient
    {
        public void GetPersons(Action<List<Person>> callback)
        {
            
            var client = new RestClient("https://raw.github.com/bekkopen/dotnetkurs/master/PersonPhoneApp/");
            client.AddHandler("text/plain", new JsonDeserializer());

            var request = new RestRequest("Persons.json", Method.GET) {RequestFormat = DataFormat.Json};
            
            Debug.WriteLine("Making request to: " + client.BuildUri(request).ToString());

            client.ExecuteAsync<List<Person>>(request, response => {
                if (response.ErrorException == null && response.StatusCode == HttpStatusCode.OK)
                    callback(response.Data);
                else
                {
                    Debug.WriteLine(response.StatusCode);
                    if(response.ErrorException != null)
                        Debug.WriteLine(response.ErrorException.ToString());
                    callback(new List<Person>());
                }
            });
        }
    }
}