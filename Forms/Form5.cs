using fil_sys.Models;
using System;
using System.Windows.Forms;

namespace fil_sys
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form2 f = (Form2)Application.OpenForms["Form2"];

            f.addDyrektor(tbRodzaj.Text);
            Dyrektor.saveToFile();
            Close();
        }
    }
}
