using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dato.Aleatorio
{
    public partial class frmDatosAleatorios : Form
    {
        Random rnd = new Random();
        public frmDatosAleatorios()
        {
            InitializeComponent();
        }

        private void frmDatosAleatorios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();

            string[] nombres = { "Ana", "Tomas", "Yesenia", "Marco", "Alexi", "Gonza" };
            char[] grupos = { 'A', 'B', 'C', 'D' };

            emp.Numero = rnd.Next(1, 10);
            emp.Nombre = nombres[rnd.Next(nombres.Length)];
            emp.FechaNacimiento = new DateTime(rnd.Next(2000, 2007), rnd.Next(1, 13), rnd.Next(1, 29));
            emp.Sexo = rnd.Next(2) == 0 ? "Femenino" : "Masculino";
            emp.Grupo = grupos[rnd.Next(grupos.Length)];
            emp.Sueldo = rnd.Next(5000, 25001);
            emp.SeguroMedico = rnd.Next(2) == 0 ? false : true;


            // MessageBox.Show(emp.ToString());


            numero.Text = emp.Numero.ToString();
            nmb.Text = emp.Nombre;
            fechn.Value = emp.FechaNacimiento;

            if (emp.Sexo == "Femenino")
                mas.Checked = true;
            else
                fem.Checked = true;

            grp.SelectedItem = "Grupo " + emp.Grupo;
            sld.Text = emp.Sueldo.ToString();

            sgrm.Checked = emp.SeguroMedico;
        }

        private void numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmb_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sld_TextChanged(object sender, EventArgs e)
        {

        }

        private void sgrm_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
