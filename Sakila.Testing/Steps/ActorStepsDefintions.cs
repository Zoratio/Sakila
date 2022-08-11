using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SakilaBackend.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sakila.Testing.Steps
{
    [Binding]
    public class ActorStepsDefintions
    {
        HttpClient? _client;
        HttpResponseMessage? response;
        IEnumerable<Actor>? model;
        //String responsePhrase;

        [Given(@"I am a user interacting with the database api")]
        public void GivenIAmAUserInteractingWithTheDatabaseApi()
        {
            _client = new HttpClient();
            //-add the new person to replace (check if they are already there first)
        }
        
        [When(@"I make a get request to getActor")]
        public async Task WhenIMakeAGetRequestToGetactorAsync()
        {
            string url = $@"https://sakilabackend20220809145429.azurewebsites.net/getActor/1";
            response = await _client.GetAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();
            model = JsonConvert.DeserializeObject<IEnumerable<Actor>>(responseString);
            //responsePhrase = response.ReasonPhrase;
        }
        
        [Then(@"the response status code is ""(.*)""")]
        public void ThenTheResponseStatusCodeIs(int expected)
        {
            Assert.AreEqual(expected, (int)response.StatusCode);
        }

        [Then(@"returned FirstName is ""(.*)""")]
        public void ThenReturnedFirstNameIs(string expected)
        {
            Assert.AreEqual(expected, model.ElementAt(0).FirstName);
        }

        [Then(@"returned LastName is ""(.*)""")]
        public void ThenReturnedLastNameIs(string expected)
        {
            Assert.AreEqual(expected, model.ElementAt(0).LastName);
        }





        [When(@"I make a put request to updateExistingActorName (.*) (.*) (.*) (.*)")]
        public async Task WhenIMakeAPutRequestToUpdateExistingActorName(string originalfirstname, string originallastname, string newfirstname, string newlastname)
        {
            string url = $@"https://sakilabackend20220809145429.azurewebsites.net/updateExistingActorName/"+originalfirstname+"/"+originallastname+"/"+newfirstname+" /"+newlastname;
            var data = new StringContent(url, System.Text.Encoding.UTF8, "application/json");   //"TAYLOR/BROMLEY");
            response = await _client.PutAsync(url, data);
            //response = await _client.GetAsync(url);
            //url = $@"https://sakilabackend20220809145429.azurewebsites.net/getActor/200";
            response = await _client.GetAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();
            model = JsonConvert.DeserializeObject<IEnumerable<Actor>>(responseString);
        }

        [Then(@"the first name (.*) and last name (.*) of actor is equals to the names entered")]
        public void ThenTheFirstNameAndLastNameOfActorWithTheIDIsEqualsToTheNamesEntered(string expectedFirstName, string expectedLastName)
        {   
            Assert.AreEqual(expectedFirstName, model.ElementAt(0).FirstName);
            Assert.AreEqual(expectedLastName, model.ElementAt(0).LastName);

            string url = $@"https://sakilabackend20220809145429.azurewebsites.net/updateExistingActorName/TAYLOR/BROMLEY/THORA/TEMPLE";//add and delete better
        }
    }
}
