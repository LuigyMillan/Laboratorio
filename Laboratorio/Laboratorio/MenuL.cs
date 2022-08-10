using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio
{
    public partial class MenuL : Form
    {
        public MenuL()
        {
            InitializeComponent();
        }

        private void btnRegistroPaci_Click(object sender, EventArgs e)
        {
            Registro_paciente pacient = new Registro_paciente();
            pacient.Show();
        }

        private void btnAtencionNacio_Click(object sender, EventArgs e)
        {
            Atencion_Nacional nacionall = new Atencion_Nacional();
            nacionall.Show();
        }

        private void btnRegistroExam_Click(object sender, EventArgs e)
        {
            Registro_examen examen = new Registro_examen();
            examen.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuL_Load(object sender, EventArgs e)
        {

        }
    }
}
