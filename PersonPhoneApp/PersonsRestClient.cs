using System;
using System.Collections.Generic;
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
            client.ExecuteAsync<List<Person>>(request, response => callback(response.Data));
        }
    }
}