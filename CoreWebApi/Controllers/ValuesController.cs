using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // static readonly HttpClient client = new HttpClient ();
        // // GET api/values
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<string>>> Get () {
        //     try {
        //         HttpResponseMessage response = await client.GetAsync ("http://core-web-api-service:5002/api/values");
        //         response.EnsureSuccessStatusCode ();
        //         string responseBody = await response.Content.ReadAsStringAsync ();

        //         Console.WriteLine (response.StatusCode);
        //         Console.WriteLine ("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
        //         Console.WriteLine ("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
        //         Console.WriteLine ("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
        //         Console.WriteLine ("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
        //         Console.WriteLine ("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
        //         Console.WriteLine ("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
        //     } catch (HttpRequestException e) {
        //         Console.WriteLine ("\nException Caught!");
        //         Console.WriteLine ("Message :{0} ", e.Message);
        //         Console.WriteLine ("StackTrace :{0} ", e.StackTrace);
        //     }
        //     Console.WriteLine ("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
        //     return new string[] { "value1", "value2" };
        // }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value) { }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}