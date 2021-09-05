using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form2 : Form
    {
        public ProducotModel owo;
        public Form2()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
        private void ClearTextBoxes()
        {

            txtName.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtExpire.Text = string.Empty;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string name, Description;

            name = txtName.Text;
            Description = txtDesc.Text;
            int quantity;
            decimal price;
            DateTime x;
            if (name == "")
            {
                MessageBox.Show("Debe llenar la caja de texto con el nombre.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (name is int)
            {
                MessageBox.Show($"Error, el nombre:{txtName.Text} no tiene el formato correcto.",
                           "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (name is decimal)
            {
                MessageBox.Show($"Error, el nombre:{txtName.Text} no tiene el formato correcto.",
                      "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Description = txtDesc.Text;
            if (Description == "")
            {
                MessageBox.Show("Debe llenar la caja de texto con la descrpcion.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Description is int)
            {
                MessageBox.Show($"Error, la descrpcion:{txtDesc.Text} no tiene el formato correcto.",
                           "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (Description is decimal)
            {
                MessageBox.Show($"Error, la descrpcion:{txtDesc.Text} no tiene el formato correcto.",
                      "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Producto prow = new Producto()
            {
                Id = ++count,
                Name = Name,
                Description = Description,
                Quantity = quantity,
                Price = price,
                CaducityDate = x,
                cmbBusqueda = (cmbBusqueda)Enum.GetValues(typeof(cmbBusqueda))
.GetValue(cmbBusqueda.SelectedIndex)
            };

            owo.Add(prow);
            MessageBox.Show($@"             ID: {prow.Id}
            Name: {prow.Name}
            Description: {prow.Description}
            Quantity: {prow.Quantity}
            Price: {prow.Price}
            CaducityTime: {prow.CaducityDate}
            Measurement: {prow.MeasuUnit}");

            ClearTextBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbBusqueda x;
            if ((cmbBusqueda == null))
            {
                MessageBox.Show($"Error, llene todos los espacios.",
                              "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                x = (cmbBusqueda)Enum.GetValues(typeof(cmbBusqueda))
                    .GetValue(cmbBusqueda.SelectedIndex);
            }
            string f = owo.GetProductoByUnidadMedida(x);
            this.richTextBox1.Text = f;

        }
        public Producto[] OrdenarByPrecio()
        {
            Array.Sort(productos, new Producto.ProductPriceComparer());

            return productos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(owo.ConvertirProductoAJson());
        }
    }

    //Se hizo lo que se pudo profe, aun asi tiene sus errores ahi, pero lo intentamos ?)
}
