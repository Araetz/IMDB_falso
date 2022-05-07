using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDB_falso.App_Code
{
    public class Persona
    {
        public string firstName;
        public string secondName; 
        public string origin;
        public string image; 
        public DateTime birth;
        public DateTime death; 

        public Persona()
        {
            firstName = "Brad";
            secondName = "Pitt"; 
            origin="USA";
            image= "https://phantom-telva.unidadeditorial.es/9f36b345c8c05bd2a22505c42b5f9b37/crop/0x88/1919x1241/resize/1280/f/webp/assets/multimedia/imagenes/2021/03/22/16164158358607.jpg"; 
            birth = new DateTime(1963, 12, 18); 
        }
    }




}

   
