using AnimesPro.Models.Entities.Animes;
using AnimesPro.Models;
using AnimesPro.Models.Entities.Animes;
using System.IO;
using System.Xml.Linq;


namespace AnimesPro.Repositories
{
    public interface IAnimesRepository
    {
        public bool CreateAnime(PostAnimesRequest anime);
        public List<Animes> GetAnimeByDirector(string director);
        public List<Animes> GetAnimeByName(string name);
        public List<Animes> GetAnimeByWord(string word);
        public bool UpdateAnime(UpdateAnimesRequest anime);
        public bool DeleteAnime(int id);
    }

    public class AnimesRepository : IAnimesRepository
    {
        private readonly _DbContext db;

        public AnimesRepository(_DbContext _db)
        {
            db = _db;
        }
        public bool CreateAnime(PostAnimesRequest anime)
        {
            try
            {
                var anime_db = new Animes()
                {
                    Name = anime.Name,
                    Summary = anime.Summary,
                    Director = anime.Director,
                    CreatedAt = DateTime.UtcNow
                };

                db.animes.Add(anime_db);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Animes> GetAnimeByDirector(string director)
        {
            try
            {
                return db.animes.Where(x => x.Director == director.ToLower()).ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<Animes> GetAnimeByName(string name)
        {
            try
            {
                return db.animes.Where(x => x.Name == name.ToLower()).ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<Animes> GetAnimeByWord(string word)
        {
            try
            {
                return db.animes.Where(x => x.Summary.Contains(word.ToLower())).ToList();
            }
            catch
            {
                return null;
            }
        }
        public bool UpdateAnime(UpdateAnimesRequest anime)
        {
            try
            {
                var anime_db = db.animes.Find(anime.id);

                anime_db.Name = anime.Name;
                anime_db.Summary = anime.Summary;
                anime_db.Director = anime.Director;

                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteAnime(int id)
        {
            try
            {
                var anime_db = db.animes.Find(id);
                anime_db.DeletedAnime = true;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

