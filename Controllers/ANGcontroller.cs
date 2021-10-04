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
    public class ANGcontroller : ControllerBase
    {
        [HttpGet("{p1}/{p2}")]

        public string Get(string p1, string p2)
        {
            ANAGRAMA ang = new ANAGRAMA();
            ang.p1 = p1;
            ang.p2 = p2;
            ang.p1.ToLower();
            ang.p2.ToLower();

                 ang.p1 = string.Concat(p1.OrderBy(x => x).ToArray());
                 ang.p2 = string.Concat(p2.OrderBy(x => x).ToArray());
            if (ang.p1 == ang.p2)
            {
                     ang.sol = "SU PETCIÓN RESULTÓ SER UN ANAGRAMA!";
            }
                else { ang.sol = "SU PETICIÓN RESULTÓ NO SER UN ANAGRAMA!!!"; }

            return ang.sol;


        }

    }
}