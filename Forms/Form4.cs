using fil_sys.Models;
using System;
using System.Windows.Forms;

namespace fil_sys
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form2 f = (Form2)Application.OpenForms["Form2"];

            f.addDyrygent(tbPensja.Text);

            Dyrygent.saveToFile();
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
