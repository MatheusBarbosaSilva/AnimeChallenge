using AnimesPro.Controllers;
using AnimesPro.Models;
using AnimesPro.Models.Entities.Animes;
using AnimesPro.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AnimesProTester
{
    [TestClass]
    public class AnimesControllerTest
    {
        private readonly IAnimesRepository repos;
        AnimesController controller;
        Animes animes;
        PostAnimesRequest postAnimesRequest;

        [TestInitialize]
        public void Start()
        {
            controller = new AnimesController(repos);
            animes = new Animes();
            postAnimesRequest = new PostAnimesRequest();
        }

        [TestMethod]
        public void CreateAnime_Test_OK()
        {
            postAnimesRequest.Name = "TesteUnitário";
            postAnimesRequest.Summary = "TesteUnitário";
            postAnimesRequest.Director = "TesteUnitário";

            var responseAPI = controller.CreateAnime(postAnimesRequest);

            Assert.IsInstanceOfType(responseAPI, typeof(OkResult));             //Testanto se a instancia do responseAPI é do mesmo tipo do retorno.
        }
    }
}