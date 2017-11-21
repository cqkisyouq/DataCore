using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniApps.Core.Interface;
using DataTest.Domain.Mapping;

namespace DataTest.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IUserService userService;
        public ValuesController(IUserService _userService)
        {
            userService = _userService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var ds=userService.GetEntities(x => x.Name.Length > 0).FirstOrDefault();
            userService.Insert(new EFDataAuth.Test.Domain.Data.Users() { Name="1111",Phone="123123123"});
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
