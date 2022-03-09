using Microsoft.AspNetCore.Mvc;
using NetWebAPI.Dao;
using NetWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetWebAPI.Controllers
{
    [Route("/")]
    public class ContentController : ControllerBase
    {
        Content content = new Content();


       [HttpGet]
       [Route("getcitylist")]
       public async Task<string> GetCityList()
        {
            return await content.GetCityList();
        }


        [HttpPost]
        [Route("postCity")]
        [Consumes("application/json")]
        public async Task<string> PostCity([FromBody]City req)
        {
            return await content.PostCity(req);
        }

        [HttpPut]
        [Route("putCity")]
        [Consumes("application/json")]
        public async Task<string> PutCity([FromBody] City req)
        {
            return await content.PutCity(req);
        }

        [HttpDelete]
        [Route("deleteCity")]
        [Consumes("application/json")]
        public async Task<string> DeleteCity([FromBody] City req)
        {
            return await content.DeleteCity(req);
        }

        [HttpGet]
        [Route("getflattypelist")]
        public async Task<string> GetFlatTypeList()
        {
            return await content.GetFlatTypeList();
        }
    }
}
