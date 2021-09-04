using System;
using System.Collections.Generic;
using System.Text;

namespace Domainzzz
{
    class ProductoModel
    {

        private Producto[] productos;


        public ProductoModel() { }

        public void Add(Producto p)
        {
            if (productos == null)
            {
                productos = new Producto[1];
                productos[0] = p;
                return;
            }
            Producto[] tmp = new Producto[productos.Length + 1];
            Array.Copy(productos, tmp, productos.Length);
            tmp[tmp.Length - 1] = p;
            productos = tmp;

        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public bool Update(Producto p) {
            bool success = false;
            int index = GetIndex(p);
            if(index < 0)
            {
                //throw new ArgumentException($"Error, producto con codigo"{p. })

            }

          

        }
        public bool Delete(Producto p)
        {
            bool flag = false;
            int index = GetIndex(p);

            if (index < 0) {
                throw new ArgumentException($"Error, producto con codigo {p.Id},no es valido");
            }
            Producto[] tmp = new Producto[productos.Length - 1];
            productos[index] = productos[productos.Length - 1];
            Array.Copy(productos, tmp, productos.Length - 1);
            productos = tmp;

            return !flag;
        }

        public Producto FindById()
        {
            int index = -1;
            for (int i= 0; i < productos.Length; i++) {
                if (productos[i].Id == id) {
                    index = i;
                    break;
                }

            }
            return index < 0 ? null : productos[index]; 

        }

        public  int GetIndex(Producto p)
        {
            int index = -1, i = 0;
            foreach (Producto producto in productos) {
                if (producto.Id == p.Id) {
                    index = i;
                    break;
                }
            }
            return index
        }
    }
}
