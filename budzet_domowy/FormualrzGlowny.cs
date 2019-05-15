using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using budzet_domowy.Model;

namespace budzet_domowy
{
    public partial class FormualrzGlowny : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public FormularzDodaj AddEditOperationForm { get; set; }
        public OperationDto OperationDto { get; set; }
        public static string WyszukajTekst { get; set; }

        public FormualrzGlowny()
        {
            InitializeComponent();
            AddEditOperationForm = new FormularzDodaj(this);
        }

        public void ChartPie()
        {
            List<string> chk_kategorie = new List<string>();
            List<DateTime> chk_daty = new List<DateTime>();
            List<string> chk_uzytkownicy = new List<string>();
            GetCheckedNodes(tW_kategorie.Nodes, chk_kategorie);
            GetDates(tW_daty.Nodes, chk_daty);
            GetChecked_uzytkownicy(tW_users.Nodes, chk_uzytkownicy);

            chart1.Series["s2"].Points.Clear();


            foreach (var kat in chk_kategorie)
            {
                List<string> list = new List<string>();
                list.Add(kat);

                var operation = DBaccess.GetOperationWithCategory(chk_daty, list,
                    chk_uzytkownicy.Select(s => int.Parse(s)).ToList());

                if (operation.FirstOrDefault() != null)
                {
                    var suma = operation.Sum(x => x.Kwota);
                    chart1.Series["s2"].Points.AddXY(kat, suma);
                }

            }
        }

        public void LineChart()
        {
            List<string> chk_kategorie = new List<string>();
            List<DateTime> chk_daty = new List<DateTime>();
            List<string> chk_uzytkownicy = new List<string>();
            GetCheckedNodes(tW_kategorie.Nodes, chk_kategorie);
            GetDates(tW_daty.Nodes, chk_daty);
            GetChecked_uzytkownicy(tW_users.Nodes, chk_uzytkownicy);

            chart2.Series["Wydatki"].Points.Clear();

                chart2.Series[0].XValueType = ChartValueType.DateTime;

                var ListOfDataExpense = DBaccess.GetOperationWithCategory(chk_daty, chk_kategorie, chk_uzytkownicy.Select(s => int.Parse(s)).ToList())
                    .Select(x => new { date = x.Data, price = x.Typ.Equals("wydatek") ? x.Kwota : 0 });

                var ListOfDataIncome = DBaccess.GetOperationWithCategory(chk_daty, chk_kategorie, chk_uzytkownicy.Select(s => int.Parse(s)).ToList())                   
                    .Select(x => new { date = x.Data, price = x.Typ.Equals("przychod") ? x.Kwota : 0 });

                chart2.Series[0].Points.DataBind(ListOfDataExpense, "date", "price", "");
                chart2.Series[0].XValueType = ChartValueType.DateTime;

                chart2.Series[1].Points.DataBind(ListOfDataIncome, "date", "price", "");
                chart2.Series[1].XValueType = ChartValueType.DateTime;

                chart2.Series[0].Color = Color.Red;
                chart2.Series[0].BorderWidth = 5;

                chart2.Series[1].Color = Color.Green;
                chart2.Series[1].BorderWidth = 5;

                chart2.Series[0].IsValueShownAsLabel = true;
                chart2.Series[0].Font = new Font(Font.SystemFontName, 15, FontStyle.Regular);
                chart2.Series[0].MarkerSize = 7;
                chart2.Series[0].MarkerColor = Color.DarkRed;
                chart2.Series[0].MarkerBorderColor = Color.Black;
                chart2.Series[0].MarkerStyle = MarkerStyle.Circle;

                chart2.Series[1].IsValueShownAsLabel = true;
                chart2.Series[1].Font = new Font(Font.SystemFontName, 15, FontStyle.Regular);
                chart2.Series[1].MarkerSize = 7;
                chart2.Series[1].MarkerColor = Color.DarkGreen;
                chart2.Series[1].MarkerBorderColor = Color.Black;
                chart2.Series[1].MarkerStyle = MarkerStyle.Circle;
        }

        public void ColumnChart()
        {
            List<string> chk_kategorie = new List<string>();
            List<DateTime> chk_daty = new List<DateTime>();
            List<string> chk_uzytkownicy = new List<string>();
            GetCheckedNodes(tW_kategorie.Nodes, chk_kategorie);
            GetDates(tW_daty.Nodes, chk_daty);
            GetChecked_uzytkownicy(tW_users.Nodes, chk_uzytkownicy);
            chart3.Series["s1"].Points.Clear();

                var operation = DBaccess.GetOperationWithCategory(chk_daty, chk_kategorie, chk_uzytkownicy.Select(s => int.Parse(s)).ToList());
            var sumaPrzychody = operation.Where(x => x.Typ.Equals("przychod")).Sum(x => x.Kwota);
                var sumaWydatki = operation.Where(x => x.Typ.Equals("wydatek")).Sum(x => x.Kwota);

                chart3.Series["s1"].Points.AddXY("Wydatki - " + sumaWydatki, sumaWydatki);
                chart3.Series["s1"].Points.AddXY("Przychody - " + sumaPrzychody, sumaPrzychody);

                chart3.Series[0].Points[0].Color = Color.Red;
                chart3.Series[0].Points[1].Color = Color.Green;
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddEditOperationForm.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            var NewForm = new FormularzUzytkownik();
            NewForm.Show();
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            FormularzUzytkownik fu = new FormularzUzytkownik();
            fu.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AddEditOperationForm.ResetForm();
            AddEditOperationForm.ShowDialog();
        }

        private void FormualrzGlowny_Load(object sender, EventArgs e)
        {
            UpdateOperationList();
            wyswietlDaty();
            wyswietlUzytkownikow();
            wczytaj_kategorie();
            ustaw_wszystko_na_checked(tW_daty.Nodes);
            ustaw_wszystko_na_checked(tW_kategorie.Nodes);
            ustaw_wszystko_na_checked(tW_users.Nodes);
            stworz_liste();
            ChartPie();
            LineChart();
            ColumnChart();
        }

        public void UpdateOperationList()
        {
            // TODO: This line of code loads data into the 'baza_danychDataSet.operacje' table. You can move, or remove it, as needed.
            this.operacjeTableAdapter.Fill(this.baza_danychDataSet.operacje);
        }

        private void EditOperation_Click(object sender, EventArgs e)
        {
            var rows = LV_operacje.SelectedItems;
 ;
            if (rows.Count > 0)
            {
                
                var row = rows[0];
                var a = row.SubItems[1];
                int x = Int32.Parse(rows[0].SubItems[0].Text);
                AddEditOperationForm.SetEditedItem(x);
                AddEditOperationForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Musisz najpierw wybrać operacje!");
            }

        }

        public void DeleteOperation_Click(object sender, EventArgs e)
        {
            var rows = LV_operacje.SelectedItems;
            if (rows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć ten rekord?",
                    "Potwierdź usunięcie",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var context = new DataClasses2DataContext())
                    {
                        //foreach (var row in rows.AsQueryable())
                        //{
                        var a = context.operacje.ToList();
                        var operation =
                            context.operacje.FirstOrDefault(x => x.id_operacji == Int32.Parse(rows[0].SubItems[0].Text));
                            context.operacje.DeleteOnSubmit(operation ?? throw new InvalidOperationException());
                        //}
                        context.SubmitChanges();
                        UpdateOperationList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Musisz najpierw wybrać operacje!");
            }
            stworz_liste();
            ChartPie();
            LineChart();
            ColumnChart();
        }

        void wyswietlDaty()
        {
            tW_daty.Nodes.Add("(Wszystkie daty)", "(Wszystkie daty)");
            var query = db.operacje.Select(r => r.data.Date).Distinct();

            foreach (var r in query)
            {
                if (tW_daty.Nodes[r.Year.ToString()] == null)
                {
                    tW_daty.Nodes.Add(r.Year.ToString(), r.Year.ToString());
                }
                if (tW_daty.Nodes[r.Year.ToString()].Nodes[r.Month.ToString()] == null)
                {
                    tW_daty.Nodes[r.Year.ToString()].Nodes.Add(r.Month.ToString(), r.Month.ToString());
                }
                if (tW_daty.Nodes[r.Year.ToString()].Nodes[r.Month.ToString()].Nodes[r.Day.ToString()] == null)
                {
                    tW_daty.Nodes[r.Year.ToString()].Nodes[r.Month.ToString()].Nodes.Add(r.Day.ToString(), r.Day.ToString());
                }
            }
            tW_daty.ExpandAll();
        }

        public void wczytaj_kategorie()
        {
            tW_kategorie.Nodes.Clear();
            tW_kategorie.Nodes.Add("wydatek", "Wydatek");
            tW_kategorie.Nodes.Add("przychod", "Przychód");
            var databaseResult = db.kategoria
                .Where(t => t.id_nadkategoria == null).ToList();
            foreach (var item in databaseResult)
            {
                if (item.typ == "wydatek")
                {
                    tW_kategorie.Nodes["wydatek"].Nodes.Add(item.nazwa, item.nazwa);
                }
                else
                {
                    tW_kategorie.Nodes["przychod"].Nodes.Add(item.nazwa, item.nazwa);
                }
            }
            var query = from op in db.kategoria
                        join op1 in db.kategoria on op.id_kategoria equals op1.id_nadkategoria
                        select new { op, op1 };
            foreach (var n in query)
            {
                if (n.op.typ == "wydatek")
                {
                    tW_kategorie.Nodes["wydatek"].Nodes[n.op.nazwa].Nodes.Add(n.op1.nazwa);
                }
                else
                {
                    tW_kategorie.Nodes["przychod"].Nodes[n.op.nazwa].Nodes.Add(n.op1.nazwa);
                }
            }
            tW_kategorie.ExpandAll();
        }
        Point p;

        public int OtwartyUcDodajKategorie { get; set; }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var text = string.Empty;
            if (tW_kategorie.SelectedNode != null)
            {
                int id;
                using (var context = new DataClasses2DataContext())
                {
                    if (tW_kategorie.SelectedNode.Level == 0)
                    {
                        id = -1;
                        if (tW_kategorie.SelectedNode.Name == "wydatek")
                        {
                            text = "wydatek";
                        }
                        else
                        {
                            text = "przychod";
                        }
                    }

                    else if (tW_kategorie.SelectedNode.Level == 1) // dodaj kat jak kliknie na nadkategorie
                    {
                        var query = context.kategoria.Where(t => t.nazwa == tW_kategorie.SelectedNode.Text);
                        id = query.FirstOrDefault().id_kategoria;
                    }
                    else
                    {
                        var query = context.kategoria.Where(t => t.nazwa == tW_kategorie.SelectedNode.Parent.Text);
                        id = query.FirstOrDefault().id_kategoria;
                    }
                }
                var uDK = new uc_dodaj_kategorię(this, 0, id, text)
                {
                    Size = new Size(121, 90),
                    Location = new Point(3, 250)
                };
                this.Controls.Add(uDK);
                uDK.BringToFront();
            }
        }

        private void zmieńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OtwartyUcDodajKategorie == 0)
            {
                if (tW_kategorie.SelectedNode != null && tW_kategorie.SelectedNode.Level > 0)
                {
                    OtwartyUcDodajKategorie = 1;
                    var uDK = new uc_dodaj_kategorię(this, 1, tW_kategorie.SelectedNode.Text);
                    uDK.Size = new Size(121, 90);
                    uDK.Location = new Point(p.X-50, p.Y-90);
                    this.Controls.Add(uDK);
                    uDK.BringToFront();
                    uDK.Tekst = tW_kategorie.SelectedNode.Text;
                }
            }
        }
        void ustaw_wszystko_na_checked(TreeNodeCollection aNode)
        {
            foreach(TreeNode wezel in aNode)
            {
                wezel.Checked = true;
                CheckAllChildNodes(wezel, true);
            }
        }

        public void stworz_liste()
        {
            List<string> chk_kategorie = new List<string>();
            List<DateTime> chk_daty = new List<DateTime>();
            List<string> chk_uzytkownicy = new List<string>();
            GetCheckedNodes(tW_kategorie.Nodes, chk_kategorie);
            GetDates(tW_daty.Nodes, chk_daty);
            GetChecked_uzytkownicy(tW_users.Nodes, chk_uzytkownicy);

            LV_operacje.Items.Clear();

            var query = DBaccess.GetOperationToList(chk_daty, chk_kategorie, chk_uzytkownicy.Select(s => int.Parse(s)).ToList());
            AddListViewData(query);

        }

        private void AddListViewData(IEnumerable<OperationDto> query)
        {
            foreach (var row in query)
            {
                var 
                nowy_rekord = LV_operacje.Items.Add(row.Id.ToString());
                nowy_rekord.SubItems.Add(row.Data.ToShortDateString());
                nowy_rekord.SubItems.Add(row.Price.ToString());
                nowy_rekord.SubItems.Add(row.FullName);
                nowy_rekord.SubItems.Add(row.Type);
                nowy_rekord.SubItems.Add(row.Category);
                nowy_rekord.SubItems.Add(row.Podcategory);
                nowy_rekord.SubItems.Add(row.PaymentForm);
                nowy_rekord.SubItems.Add(row.Description);
            }
        }

        public void GetDates(TreeNodeCollection nodes, List<DateTime> chk_daty)
        {

            foreach (System.Windows.Forms.TreeNode aNode in nodes)
            {
                //edit
                if (aNode.Checked && aNode.Level == 2)
                    chk_daty.Add(DateTime.Parse(aNode.Name+"."+aNode.Parent.Name+"-"+aNode.Parent.Parent.Name+" 00:00:00"));

                if (aNode.Nodes.Count != 0)
                    GetDates(aNode.Nodes, chk_daty);
            }
        }

        public void GetCheckedNodes(TreeNodeCollection nodes, List<string> chk_kategorie)
        {

            foreach (System.Windows.Forms.TreeNode aNode in nodes)
            {
                //edit
                if (aNode.Checked && aNode.Level == 2)
                    chk_kategorie.Add(aNode.Text);

                if (aNode.Nodes.Count != 0)
                    GetCheckedNodes(aNode.Nodes, chk_kategorie);
            }
        }
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }
        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            List<DateTime> daty = new List<DateTime>();
            GetDates(tW_daty.Nodes, daty);
            foreach(var u in daty)
            {
                MessageBox.Show(u.ToShortDateString());
            }
        }

        private void tW_kategorie_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
            stworz_liste();
            ChartPie();
            LineChart();
            ColumnChart();
        }

        private void tW_daty_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Name == "(Wszystkie daty)")
                {
                    ustaw_wszystko_na_checked(tW_daty.Nodes);
                }
                else if (e.Node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }

            stworz_liste();
            ChartPie();
            LineChart();
            ColumnChart();
        }
        public void GetChecked_uzytkownicy(TreeNodeCollection nodes, List<string> chk_kategorie)
        {

            foreach (System.Windows.Forms.TreeNode aNode in nodes)
            {
                //edit
                if (aNode.Checked)
                    chk_kategorie.Add(aNode.Name);

                if (aNode.Nodes.Count != 0)
                    GetChecked_uzytkownicy(aNode.Nodes, chk_kategorie);
            }
        }

        private void WyszukajButton_Click(object sender, EventArgs e)
        {
            Wyszukaj wyszukaj = new Wyszukaj(this);
            wyszukaj.Show();
        }

        void wyswietlUzytkownikow()
        {
            using (var context = new DataClasses2DataContext())
            {
                var query = from u in context.uzytkownicy
                    select new
                    {
                        uzytkownik = u.imie + " " + u.nazwisko,
                        id = u.id_uzytkownika
                    };
                foreach (var r in query)
                {
                    tW_users.Nodes.Add(r.id.ToString(), r.uzytkownik);
                }
            }
        }

        private void tW_users_AfterCheck(object sender, TreeViewEventArgs e)
        {
            stworz_liste();
            ChartPie();
            LineChart();
            ColumnChart();
        }
    }
}
