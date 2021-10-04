using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicios;
    namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IMCcontroller : ControllerBase
    {
        [HttpGet("{p}/{a}")]

        public string Get(double p, double a)
        {
           IMC oimc = new IMC();

            oimc.p = p;
            oimc.a = a;
            oimc.operacion = (p / (a * a));

            if (oimc.operacion > 25 && oimc.operacion < 29.9)
            { oimc.resultado = "TU IMC ES MUY ALTO!"; }
            else if (oimc.operacion > 18.5 && oimc.operacion < 24.9)
            { oimc.resultado = "TU IMC ES NORMAL, BIEN!"; }
            else if (oimc.operacion < 18.5)
            { oimc.resultado = "TU IMC ES MUY BAJO!!"; }
            else
            { oimc.resultado = "TU IMC ES DEMASIADO ALTO, PORFAVOR VISITA A TÚ NUTRIOLOGO DE CONFIANZA"; }

            return $"EL RESULTADO SOLICITADO DEL IMC ES DE : {Math.Round(oimc.operacion, 2)} : {oimc.resultado}";
    }
    }
    }