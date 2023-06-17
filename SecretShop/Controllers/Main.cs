using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace SecretShop.Controllers
{
    [Controller]
    public class ApiToBdController : Controller
    {

       public string Main()
        {;
            string json = JsonConvert.SerializeObject(OutputCategory.SortedToRating());
            return json;
        }

    }
}