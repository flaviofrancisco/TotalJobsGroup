using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using PairingTest.Web.Helpers;
using PairingTest.Web.Models;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        const string _url = "http://localhost:50014/api/questions";
        HttpClient _httpClient;

        public QuestionnaireController()
        {
            _httpClient = HttpClientHelper.GetHttpClient(_url);
        }

        public async Task<ActionResult> Index()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_url);

            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;

                var questionnaireViewModel = JsonConvert.DeserializeObject<QuestionnaireViewModel>(data);

                return View(questionnaireViewModel);
            }

            return View(new QuestionnaireViewModel());
        }
    }
}
