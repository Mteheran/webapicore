using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapicore.Services;
using webapicore.Models;

namespace webapicore.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IDataService dataService;

        public UserController(IDataService dataservice)
        {
            this.dataService = dataservice;
        }


        [HttpGet]
        public ActionResult<IEnumerable<User>> Get([FromServices] IDataService data)
        {
           return dataService.Users.Union(data.Users).ToList();
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var user = dataService.GetUserById(id);

            if (user?.UserId != Guid.Empty && user?.UserId!=null)
                return Ok(user);
            else
                return NotFound("Not found");
        }

        [HttpPost]
        public void Post([FromBody] User value)
        {
            dataService.SaveUser(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}