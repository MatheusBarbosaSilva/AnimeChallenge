using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimesPro.Models.Entities.Animes
{
    public class UpdateAnimesRequest : PostAnimesRequest
    {
        public int id { get; set; }
    }
}
