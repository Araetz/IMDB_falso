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
        public List<Persona> personas = new List<Persona>(); 

        [BindProperty]
        public Persona newPersona { get; set;  }
        public void OnGet()
        {
            ReadDB(); 

        }
        public IActionResult OnPost()
        {
            //Insertar en la Base de datos
            personas.Add(newPersona); 
            // Recargar informacion de la base de datos
            ReadDB(); 
            return Page(); 
        }

        public void ReadDB()
        {
            for (int i=0; i<10; i++)
            {
                personas.Add(new Persona()); 
            }
        }
    }
}
