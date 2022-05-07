using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMDB_falso.App_Code;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IMDB_falso.Pages
{
    public class PersonasModel : PageModel
    {
        public List<Persona> personas; 
        public void OnGet()
        {
            personas = new List<Persona>();
            for (int i = 0; i < 10; i++)
            {
                personas.Add(new Persona()); 
            }

        }
    }
}
