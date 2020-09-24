using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace puc_conversao_temperatura.Models
{
    public class Temperatura
    {
        public decimal Valor { get; set; }

        public decimal ConvertCelsiusToKelvin()
        {
            return Valor + 273.15m;
        }
    }
}
