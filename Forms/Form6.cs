using fil_sys.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace fil_sys.Forms
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {

        }


        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbType.SelectedIndex)
            {
                case 0:
                    //lb.DataSource = Worker.workerList;
                    lb.Items.Clear();
                    foreach (Worker worker in Worker.workerList)
                    {
                        lb.Items.Add($"{worker.name}, {worker.surName}");
                    }

                    lb.Refresh();
                    break;
                case 1:
                    lb.Items.Clear();
                    foreach (Muzyk worker in Muzyk.muzykList)
                    {
                        lb.Items.Add($"{worker.name}, {worker.surName}");
                    }

                    lb.Refresh();

                    break;
                case 2:
                    lb.Items.Clear();
                    foreach (Dyrygent worker in Dyrygent.dyrygentList)
                    {
                        lb.Items.Add($"{worker.name}, {worker.surName}");
                    }

                    lb.Refresh();

                    break;
                case 3:

                    lb.Items.Clear();

                    foreach (Dyrektor worker in Dyrektor.dyrList)
                    {
                        lb.Items.Add($"{worker.name}, {worker.surName}");
                    }

                    lb.Refresh();

                    break;
            }
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int index = lb.SelectedIndex;

            if (index >= 0)
            {
                switch (cbType.SelectedIndex)
                {
                    case 0:
                        //index = lb.SelectedIndex;
                        string text = "";

                        text += $"Imie: {Worker.workerList[index].name}\nNaziwsko: {Worker.workerList[index].surName}\nPESEL:{Worker.workerList[index].pesel}\nLogin: {Worker.workerList[index].login}\nHasło: {Worker.workerList[index].pwd}\nTelefon: {Worker.workerList[index].phNum}";
                        richTextBox1.Text = text;
                        break;
                    case 1:
                        //index = lb.SelectedIndex;
                        string text2 = "";

                        text2 += $"Imie: {Muzyk.muzykList[index].name}\nNaziwsko: {Muzyk.muzykList[index].surName}\nPESEL:{Muzyk.muzykList[index].pesel}\nLogin: {Muzyk.muzykList[index].login}\nHasło: {Muzyk.muzykList[index].pwd}\nTelefon: {Muzyk.muzykList[index].phNum}\nRodzaj: {Muzyk.muzykList[index].rodzaj}\nInstrument: {Muzyk.muzykList[index].getInstrumentList().ElementAt(0)}\nPensja: {Muzyk.muzykList[index].pensja}";
                        richTextBox1.Text = text2;
                        break;
                    case 2:

                        // index = lb.SelectedIndex;
                        string text3 = "";


                        text3 += $"Imie: {Dyrygent.dyrygentList[index].name}\nNaziwsko: {Dyrygent.dyrygentList[index].surName}\nPESEL:{Dyrygent.dyrygentList[index].pesel}\nLogin: {Dyrygent.dyrygentList[index].login}\nHasło: {Dyrygent.dyrygentList[index].pwd}\nTelefon: {Dyrygent.dyrygentList[index].phNum}\nPensja: {Dyrygent.dyrygentList[index].pensja}";
                        richTextBox1.Text = text3;

                        break;
                    case 3:

                        //index = lb.SelectedIndex;
                        string text4 = "";

                        text4 += $"Imie: {Dyrektor.dyrList[index].name}\nNaziwsko: {Dyrektor.dyrList[index].surName}\nPESEL:{Dyrektor.dyrList[index].pesel}\nLogin: {Dyrektor.dyrList[index].login}\nHasło: {Dyrektor.dyrList[index].pwd}\nTelefon: {Dyrektor.dyrList[index].phNum}\nRodzaj: {Dyrektor.dyrList[index].rodzaj}\nPensja: {Dyrektor.pensja} ";
                        richTextBox1.Text = text4;

                        break;
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
