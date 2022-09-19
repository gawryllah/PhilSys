using fil_sys.Models;
using System;
using System.Windows.Forms;

namespace fil_sys
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string getPensja()
        {
            return tbPensja.Text;
        }

        public string getRodzaj()
        {
            return tbRodzaj.Text;
        }

        public string getInstrument()
        {

            return tbInstrument.Text;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form2 f = (Form2)Application.OpenForms["Form2"];

            f.addMuzyk(tbPensja.Text, tbRodzaj.Text, tbInstrument.Text);

            Muzyk.saveToFile();
            Close();
        }

        public Button GetButton()
        {
            return btnDodaj;
        }
    }
}
