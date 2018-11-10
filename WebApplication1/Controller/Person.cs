using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller
{
    public class Person:Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet("api/Person")]
        public JsonResult PersonName()
        {
            return  new JsonResult("Person");
        }
    }
}