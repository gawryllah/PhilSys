using fil_sys.Forms;
using fil_sys.Models;
using System;
using System.Windows.Forms;

namespace fil_sys
{
    public partial class Form1 : Form
    {
        int index;
        DateTime date;

        public Form1()
        {
            InitializeComponent();
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoSize = false;
            //lbFilharmonia.Items.Clear();
            lbWydarzenia.Items.Clear();
            foreach (Aula aula in Aula.aulaList)
            {
                lbFilharmonia.Items.Add(aula.nazwa);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            f2.Show();
            Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void btnViewWorkers_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            f2.Show();
            Hide();
        }

        private void lbFilharmonia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbWydarzenia.Items.Clear();
            index = lbFilharmonia.SelectedIndex;


            if (index >= 0)
            {

            }

        }

        private void kalendarz_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbWydarzenia.Items.Clear();
            date = kalendarz.SelectionStart;

            index = lbFilharmonia.SelectedIndex;

            if (index >= 0)
            {
                if (Aula.aulaList[index].koncrtsDate.Contains(date))
                {
                    int id = Aula.aulaList[index].koncrtsDate.IndexOf(date);

                    lbWydarzenia.Items.Add($"{date.Date.ToString().Split(" ")[0]} - {Aula.aulaList[index].koncertList[id].nazwa}");

                }

                if (Aula.aulaList[index].wystepsDate.Contains(date))
                {
                    int id = Aula.aulaList[index].wystepsDate.IndexOf(date);

                    lbWydarzenia.Items.Add($"{date.Date.ToString().Split(" ")[0]} - {Aula.aulaList[index].wystepList[id].nazwa}");
                }
            }
        }

        private void lbWydarzenia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
