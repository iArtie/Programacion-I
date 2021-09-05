using System;
using System.Collections.Generic;
using System.Text;

namespace Domainzzz
{
    class Producto
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string Description { get; set; }
        [JsonProperty]
        public int quantity { get; set; }
        [JsonProperty]
        public decimal Price { get; set; }
        [JsonProperty]
        public DateTime CaducityDate { get; set; }

        public enum Productos {
            UnidadMedida,
            Caducidad
        }

        public class ProductoComparer : IComparer<Producto>
        {
            public int Compare(Producto e1, Producto e2)
            {
                if (e1 == null || e2 == null)
                {
                    throw new ArgumentException("Error, los objetos no puedn ser null.");
                }
                if (e1.Price > e2.Price)
                {
                    return 1;
                }
                else if (e1.Price < e2.Price)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
