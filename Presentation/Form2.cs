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

        private void Button1_Click(object sender, EventArgs e)
        {
            string name, Description;

            name = txtName.Text;
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

        }


        private void TxtExpire_KeyDown(object sender, KeyEventArgs e)
        {
            int cd, i;

            if (Keys.Enter == e.KeyCode)
            {
        
                if (!int.TryParse(txtExpire.Text, out cd))
                {
                    MessageBox.Show("Error, no puede ser letras");
                }
                else
                {
                    if (cd < 0)
                    {
                        MessageBox.Show("No puede ser menor que cero");
                        return;
                    }
                    cd = int.Parse(txtExpire.Text);

                    if (i > 5)
                    {
                        MessageBox.Show("Solo se puede meter 6 notas");
                        return;

                    }
                    cd[i] = cd;

                    i++;

                    label5.Text = $"Fecha: {i}";

                    txtExpire = string.Empty;
                }
            }
        }
    }
}
