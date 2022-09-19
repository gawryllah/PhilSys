using fil_sys.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace fil_sys
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            var allTexboxes = Controls.OfType<TextBox>();

            bool isEVeryTbFilled = true;

            foreach (TextBox tb in allTexboxes)
            {
                if (tb.TextLength == 0)
                {
                    MessageBox.Show("Nie mozesz zostawic pustego pola!");
                    isEVeryTbFilled = true;
                    return;
                }

            }
            isEVeryTbFilled = false;

            if (!isEVeryTbFilled)
            {
                switch (cbToe.SelectedIndex)
                {
                    case 0:
                        Worker worker = new Worker(tbPesel.Text, tbImie.Text, tbNazwisko.Text, dpDob.Value.Date, tbLogin.Text, tbPwd.Text, tbAddress.Text, tbTelefon.Text, cbToe.Text);
                        MessageBox.Show($"Pracownik: \n{tbPesel.Text}, {tbImie.Text}, {tbNazwisko.Text}, {dpDob.Value.Date}, {tbLogin.Text}, {tbPwd.Text}, {tbAddress.Text}, {tbTelefon.Text}");

                        Worker.workerList.Add(worker);

                        Worker.saveToFile();

                        break;



                    case 1:

                        Form3 f3 = new Form3();
                        f3.ShowDialog();
                        break;
                    case 2:
                        Form4 f4 = new Form4();
                        f4.ShowDialog();
                        break;

                    case 3:
                        Form5 f5 = new Form5();
                        f5.ShowDialog();
                        break;


                }
            }






        }

        public void addDyrygent(string pensja)
        {
            Refresh();
            Dyrygent dyrygent = new Dyrygent(tbPesel.Text, tbImie.Text, tbNazwisko.Text, dpDob.Value.Date, tbLogin.Text, tbPwd.Text, tbAddress.Text, tbTelefon.Text, cbToe.Text,
               float.Parse(pensja, System.Globalization.CultureInfo.InvariantCulture));

            Dyrygent.dyrygentList.Add(dyrygent);

            MessageBox.Show($"Muzyk: \n {tbPesel.Text}, {tbImie.Text}, {tbNazwisko.Text}, {dpDob.Value.Date}, {tbLogin.Text}, {tbPwd.Text}, {tbAddress.Text}, {tbTelefon.Text}, {cbToe.Text}, {pensja}");

            Refresh();
        }

        public void addMuzyk(string pensja, string rodzaj, string instrument)
        {
            Refresh();
            Muzyk muzyk = new Muzyk(tbPesel.Text, tbImie.Text, tbNazwisko.Text, dpDob.Value.Date, tbLogin.Text, tbPwd.Text, tbAddress.Text, tbTelefon.Text, cbToe.Text,
                float.Parse(pensja, System.Globalization.CultureInfo.InvariantCulture), rodzaj, instrument);

            Muzyk.muzykList.Add(muzyk);

            MessageBox.Show($"Muzyk: \n {tbPesel.Text}, {tbImie.Text}, {tbNazwisko.Text}, {dpDob.Value.Date}, {tbLogin.Text}, {tbPwd.Text}, {tbAddress.Text}, {tbTelefon.Text}, {cbToe.Text}, {pensja}, {rodzaj}, {instrument}");
            Refresh();
        }

        public void addDyrektor(string rodzaj)
        {
            Refresh();
            Dyrektor dyrektor = new Dyrektor(tbPesel.Text, tbImie.Text, tbNazwisko.Text, dpDob.Value.Date, tbLogin.Text, tbPwd.Text, tbAddress.Text, tbTelefon.Text, cbToe.Text, rodzaj);

            Dyrektor.dyrList.Add(dyrektor);

            MessageBox.Show($"Muzyk: \n {tbPesel.Text}, {tbImie.Text}, {tbNazwisko.Text}, {dpDob.Value.Date}, {tbLogin.Text}, {tbPwd.Text}, {tbAddress.Text}, {tbTelefon.Text}, {cbToe.Text}, {rodzaj}");

            Refresh();
        }




    }
}
