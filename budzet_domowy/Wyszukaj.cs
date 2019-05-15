using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budzet_domowy
{
    public partial class Wyszukaj : Form
    {
        public FormualrzGlowny MainForm { get; set; }

        public Wyszukaj(FormualrzGlowny mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void WyszukajButton_Click(object sender, EventArgs e)
        {
            FormualrzGlowny.WyszukajTekst = WyszukajTextBox.Text;

            //var query = DBaccess.GetOperationToList().Where(x => x.Data.ToString().Equals(WyszukajText));

            MainForm.stworz_liste();


            //if (WyszukajText==query.)

        }
    }
}
