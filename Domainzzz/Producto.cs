using System;
using System.Collections.Generic;
using System.Text;

namespace Domainzzz
{
    class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int quantity { get; set; }

        public decimal Price { get; set; }
        public DateTime CaducityDate { get; set; }

        public enum Productos {
            UnidadMedida,
            Caducidad
        }
    }
}
