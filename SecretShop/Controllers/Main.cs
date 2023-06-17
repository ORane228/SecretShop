using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace SecretShop.Controllers
{
    [Controller]
    public class ApiToBdController : Controller
    {
        
        private OutputCategoryModel _outputCategory;
        public ApiToBdController(OutputCategoryModel model)
        {
            _outputCategory = model;
        }

        public string Main()
        {
            return JsonConvert.SerializeObject(_outputCategory);
        }

    }
}