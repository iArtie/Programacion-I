using Domainzzz.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Domainzzz
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Empleado
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Dni { get; set; }
        [JsonProperty]
        public string Names { get; set; }
        [JsonProperty]
        public string Lastnames { get; set; }
        [JsonProperty]
        public decimal Wage { get; set; }
        [JsonProperty]
        public NivelAcademico NivelAcademico { get; set; }
        [JsonProperty]
        public Genero Genero { get; set; }

        public class EmpleadoSalarioComparer : IComparer<Empleado>
        {
            public int Compare(Empleado e1, Empleado e2)
            {
                if (e1 == null || e2 == null)
                {
                    throw new ArgumentException("Error, los objetos no pueden ser null");
                }
                if (e1.Wage > e2.Wage)
                {
                    return 1;
                }
                else if (e1.Wage < e2.Wage)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

           
        }
        }
        public class EmpleadoNivelAcademicoComparer : IComparer<NivelAcademico>
        {
            public int Compare(NivelAcademico x, NivelAcademico y)
            {
                throw new NotImplementedException();
            }
        }
    }
}
