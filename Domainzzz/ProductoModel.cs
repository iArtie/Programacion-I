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

        public string GetList()
        {
            string result = " ";
            foreach (Producto m in productos)
            {
                result += m.Id.ToString() + " " + m.Name.ToString() + " " + m.Quantity.ToString() + " " + m.Price.ToString();
            }
            return result;
        }

        public string GetProductoPorUnidadMedida(cmbBusqueda unidad)
        {
            string result = " "; int x = 1;
            if (productos == null)
            {
                throw new ArgumentException($"Error, no ha ingresado ningun producto.");
            }

            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].MeasuUnit == unidad)
                {
                    result += x + ". Codigo: " + productos[i].Id.ToString() + " Nombre: " + productos[i].Name.ToString() +
                               " Cantidad: " + productos[i].Quantity.ToString() + " Precio: " + productos[i].Price.ToString() +
                               " Caducidad " + productos[i].CaducityDate.ToString() + " Unidad de Medida: " + productos[i].MeasuUnit.ToString() + "\n";
                    x++;
                }
            }
        }

        public string GetProductPorCaducidad(DateTime caducity)
        {
            string result = " "; int x = 1;
            if (productos == null)
            {
                throw new ArgumentException($"Error, no ha ingresado ningun producto.");
            }

            foreach (Product m in productos)
            {
                if (m.CaducityDate == caducity)
                {
                    result += x + ". Codigo: " + m.Id.ToString() + " Nombre: " + m.Name.ToString() +
                               " Cantidad: " + m.Quantity.ToString() + " Precio: " + m.Price.ToString() +
                               " Caducidad " + m.CaducityDate.ToString() + " Unidad de Medida: " + m.MeasuUnit.ToString() + "\n";
                    x++;
                }
            }

            return result;
        }

        public string ConvertirProductoAJson()
        {
            if (productos == null)
            {
                throw new ArgumentException($"Error, no ha ingresado ningun producto.");
            }
            string ObjectJson = "";
            foreach (Product f in productos)
            {
                ObjectJson += JsonConvert.SerializeObject(f);
            }
            return ObjectJson;
        }
    }
