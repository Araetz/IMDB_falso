using IMDB_falso.App_Code;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace IMDB_falso.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        [BindProperty(SupportsGet =true)]
        public int id { get; set;  }
        public DataTable dt; 



        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            DataBaseController.DB_Comparer[] conditions = new DataBaseController.DB_Comparer[]
            {
                new DataBaseController.DB_Comparer("FirstName", "Brad", DataBaseController.DB_Comparer.COMPARE_TYPE.EQUALS),
                new DataBaseController.DB_Comparer("SecondName", "Pitt", DataBaseController.DB_Comparer.COMPARE_TYPE.EQUALS),
                 new DataBaseController.DB_Comparer("SecondName", "%P%", DataBaseController.DB_Comparer.COMPARE_TYPE.LIKE)
            }; 
            // dt = DataBaseController.Select("SELECT * FROM [Person]"); 
            dt = DataBaseController.Select("Person", null, conditions);
        }
    }
}
