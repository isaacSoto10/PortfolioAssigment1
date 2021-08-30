using Microsoft.AspNetCore.Mvc;
namespace Helloasp
{
    public class HomeController: Controller
    {
        // Requests
        //localhost:5000
        [HttpGet("/")]
        public string Index()
        {
            return "This is my index!";
        }
        [HttpGet("/projects")]
        public string Index()
        {
            return "These are my projects!";
        }
        [HttpGet("/contact")]
        public string Index()
        {
            return "This is my contact!";
        }

    }

}