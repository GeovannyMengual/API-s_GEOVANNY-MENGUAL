using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicios;


namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalController : ControllerBase
    {
        [HttpGet("{P}")]

        public string Get(string P)
        {
            string pa;
            PALIDROMO pl = new PALIDROMO();
            pl.P = P;

            int cp = pl.P.Split(' ').Length;
            pl.P.ToLower().Replace(" ", "");




            if (P.Length <= 2)
            {
                pl.R = "SI SE HA INGRESADO UNA PALABRA TIPO PALINDROMA";
            }
            else if (P[0] == P[P.Length - 1])
            {
                pl.R = "VERIFICADO:) ES PALINDROMA";
            }
            else { pl.R = "NO SE HA INGRESADO UNA PALABRA PALINDROMA"; }

            if (cp > 1) { pa = "PALABRAS ESCRITAS!"; } else { pa = "PALABRA ESCRITA!"; }

            return $" {pl.R} Y CUENTA CON  {cp} {pa}";
        }
    }
}