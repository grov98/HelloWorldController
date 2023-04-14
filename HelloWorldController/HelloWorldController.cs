using System.Web.Http;

public class HelloWorldController : ApiController
{
    public IHttpActionResult Get()
    {
        return Json("Hola mundo");
    }
}

