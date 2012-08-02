using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using RestSharp;

namespace PersonPhoneApp
{
    public class PersonsRestClient
    {
        public void GetPersons(Action<List<Person>> callback)
        {
            var client = new RestClient("http://10.0.0.49:14897/");
            var request = new RestRequest("Persons/List", Method.GET);

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
