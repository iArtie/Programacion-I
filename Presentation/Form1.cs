using Domainzzz;
using Domainzzz.Enums;
using Infraestructura;
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
    public partial class Form1 : Form
    {

        public int Count { get; set; }
        public EmpleadoModel empleadoModel;
        public Form1()
        {
            empleadoModel = new EmpleadoModel();
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string dni, names, lastnames;
            decimal wage;

            //dni = txtDni.Text;
            //if (dni == "")
            //{
            //    MessageBox.Show("Debe llenar la caja de texto con su Dni.",
            //                    "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (dni is int)
            //{
            //    MessageBox.Show($"Error, el dni:{txtDni.Text} no tiene el formato correcto.",
            //               "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //else if (dni is decimal)
            //{
            //    MessageBox.Show($"Error, el dni:{txtDni.Text} no tiene el formato correcto.",
            //          "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

      
            //names = txtNombres.Text;
            //if (names == "")
            //{
            //    MessageBox.Show("Debe llenar la caja de texto con su Nombre.",
            //                    "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //lastnames = txtApellidos.Text;
            //if (lastnames == "")
            //{
            //    MessageBox.Show("Debe llenar la caja de texto con su Apellido.",
            //                    "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (!decimal.TryParse(txtSalario.Text, out wage))
            //{
            //    MessageBox.Show($"Error, el salario:{txtSalario.Text} no tiene el formato correcto.",
            //                    "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            //Empleado emp = new Empleado()
            //{
            //    Id = ++Count,
            //    Dni = dni,
            //    Names = names,
            //    Lastnames = lastnames,
            //    Wage = wage,
            //    NivelAcademico = (NivelAcademico) Enum.GetValues(typeof(NivelAcademico)).GetValue(cmbAcademicLevel.SelectedIndex),
            //    Genero = (Genero) Enum.GetValues(typeof(Genero)).GetValue(cmbGenero.SelectedIndex)
            //};


            //string jsonEmp = JsonConvert.SerializeObject(emp);

             
            
            string jsonObject = @"{
""Id"": 1,
""Dni"": ""001-000000-0000V"",
""Names"": ""Pepito"",
""Lastnames"": ""Perez"",
""Wage"": ""11200"",
""NivelAcademico"": ""4"",
""Genero"": ""1"",

}";
            Empleado emp = JsonConvert.DeserializeObject<Empleado>(jsonObject);

            empleadoModel.Add(emp);

            //  PrintInformacionMesage(jsonEmp);
            MessageBox.Show($@"
             Id: {emp.Id}
             DNI: {emp.Dni}
             Nombres:{emp.Names}
            Apellidos: {emp.Lastnames}
            Salario: {emp.Wage}
            Count: {empleadoModel.GetEmpleados().Length}");
            ClearTextboxes();




        }
        private void ClearTextboxes()
        {
            txtDni.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtDni.Focus();
        }
        public void Verificacion(string nombres, string apellidos, string dni)
        {

            if (nombres.Length > 20)
            {
                MessageBox.Show($"Error, el nombre no puede tener mas de 20 caracteres",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);


            }
            if (apellidos.Length > 20)
            {
                MessageBox.Show($"Error, el apellido no puede tener mas de 20 caracteres",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);


            }
            if (dni.Length > 16)
            {
                MessageBox.Show($"Error, el dni no puede tener mas de 16 caracteres",
                             "Mensaje de error",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);


            }
        }

        private void ButtonSalario_Click(object sender, EventArgs e)
        {
            PrintInformacionMesage($"El Salario Máximo es: {empleadoModel.GetSalarioMaximo()}");
            
        }

        private void ButtonSalarioMin_Click(object sender, EventArgs e)
        {
            PrintInformacionMesage($"El Salario Mínimo es: {empleadoModel.GetSalarioMinimo()}");
        }

        private void ButtonSP_Click(object sender, EventArgs e)
        {
            PrintInformacionMesage($"El Salario Promedio es: {empleadoModel.GetSalarioPromedio()}");
        }
        private void PrintInformacionMesage(string message)
        {
            MessageBox.Show(message, "Mensaje de Información", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ButtonMay_Click(object sender, EventArgs e)
        {
            PrintInformacionMesage($"Los Salarios Mayores que el Promedio son: {empleadoModel.GetMayorPromedio()}");
        }

        private void GroupBoxDatos_Enter(object sender, EventArgs e)
        {

        }

        private void TxtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }
    }
}
