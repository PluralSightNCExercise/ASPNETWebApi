using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Videos.Models;

namespace Videos.Controllers
{

  

    public class VideosController : ApiController
    {
        private VideoDb db;

        public VideosController()
        {
            db = new VideoDb();
            db.Configuration.ProxyCreationEnabled = false;
        }




        public IEnumerable<Video> GetAllVideos()
        {
            return db.Videos;
        }

        public string Get(int id)
        {
            return "value" + " " + id.ToString();
        }

        public Video Post ([FromBody]Video video)
        {
            return video;
        }

        public void Put(int id, string value)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
