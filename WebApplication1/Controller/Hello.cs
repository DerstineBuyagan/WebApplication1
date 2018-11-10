

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controller
{

    public class HelloController : Microsoft.AspNetCore.Mvc.Controller
    {
        //We need this for routing
        [HttpGet("api/demo")]
        public JsonResult Demo()
        {
            return new JsonResult(new List<PersonDto>
            {
                 new PersonDto
                 {
                     FirstName = "Derstine",
                     LasteName = "Derstine",
                 },
                new PersonDto
                 {
                     FirstName = "Denden",
                     LasteName = "Buyagan",
                 },
            }
            );
        }
    }

    public class PersonDto
    {
        public string FirstName { get; set; }
        public string LasteName { get; set; }
    }
}