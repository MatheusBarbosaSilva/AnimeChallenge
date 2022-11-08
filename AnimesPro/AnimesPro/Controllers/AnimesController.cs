using AnimesPro.Models.Entities.Animes;
using AnimesPro.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimesPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimesController : ControllerBase
    {
        private readonly IAnimesRepository repos;
        public AnimesController(IAnimesRepository _repos)
        {
            repos = _repos;
        }


        [HttpGet("get-director")]
        public IActionResult GetAnimeByDirector([FromHeader] string director)
        {
            var anime = repos.GetAnimeByDirector(director);
            if(anime.Count == 0)
            {
                return BadRequest("Anime Not Found");
            }
            return Ok(anime);
        }

        [HttpGet("get-name")]
        public IActionResult GetAnimeByName([FromHeader] string name)
        {
            var anime = repos.GetAnimeByName(name);
            if(anime.Count == 0)
            {
                return BadRequest("Anime Not Found");
            }
            return Ok(anime);
        }

        [HttpGet("get-word")]
        public IActionResult GetAnimeByWord([FromHeader] string word)
        {
            var anime = repos.GetAnimeByWord(word);
            if (anime.Count == 0)
            {
                return BadRequest("Anime Not Found");
            }
            return Ok(anime);
        }


        [HttpPost]
        public IActionResult CreateAnime([FromBody] PostAnimesRequest anime)
        {
            if (repos.CreateAnime(anime))
                return Ok();

            return BadRequest("Fails To Create Anime");

        }

        [HttpPut]
        public IActionResult UpdateAnime([FromBody] UpdateAnimesRequest anime)
        {
            if (repos.UpdateAnime(anime))
                return Ok();

            return BadRequest("Fails To Update Anime");

        }

        [HttpDelete("{id}")]
        public IActionResult DeletedAnime([FromRoute] int id)
        {
            if (repos.DeleteAnime(id))
                return Ok();

            return BadRequest("Fails To Delete Anime");
        }
    }
}
