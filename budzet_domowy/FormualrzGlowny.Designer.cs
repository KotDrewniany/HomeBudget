namespace budzet_domowy
{
    partial class FormualrzGlowny
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormualrzGlowny));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuGłówne = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ZamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PodgladWydrukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NarzędziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajWartośćToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ZmieńWartośćToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuńWartośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WyświetlStatystykiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.WyszukajButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.operacjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_danychDataSet = new budzet_domowy.baza_danychDataSet();
            this.operacjeTableAdapter = new budzet_domowy.baza_danychDataSetTableAdapters.operacjeTableAdapter();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tW_kategorie = new System.Windows.Forms.TreeView();
            this.MenuKateogrii = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tW_daty = new System.Windows.Forms.TreeView();
            this.tW_users = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LV_operacje = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKwota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUzytkownik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodkategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderForma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridViewOperations = new System.Windows.Forms.DataGridView();
            this.idoperacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduzytkownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idformaplatnosciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuGłówne.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operacjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_danychDataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.MenuKateogrii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperations)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuGłówne
            // 
            this.menuGłówne.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuGłówne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.NarzędziaToolStripMenuItem,
            this.WyświetlStatystykiToolStripMenuItem,
            this.kategorieToolStripMenuItem});
            this.menuGłówne.Location = new System.Drawing.Point(0, 0);
            this.menuGłówne.Name = "menuGłówne";
            this.menuGłówne.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuGłówne.Size = new System.Drawing.Size(1412, 28);
            this.menuGłówne.TabIndex = 9;
            this.menuGłówne.Text = "MenuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZamknijToolStripMenuItem,
            this.DrukujToolStripMenuItem,
            this.PodgladWydrukuToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 24);
            this.toolStripMenuItem1.Text = "&Dane";
            // 
            // ZamknijToolStripMenuItem
            // 
            this.ZamknijToolStripMenuItem.Name = "ZamknijToolStripMenuItem";
            this.ZamknijToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.ZamknijToolStripMenuItem.Text = "&Zamknij";
            // 
            // DrukujToolStripMenuItem
            // 
            this.DrukujToolStripMenuItem.Name = "DrukujToolStripMenuItem";
            this.DrukujToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.DrukujToolStripMenuItem.Text = "&Drukuj";
            // 
            // PodgladWydrukuToolStripMenuItem
            // 
            this.PodgladWydrukuToolStripMenuItem.Name = "PodgladWydrukuToolStripMenuItem";
            this.PodgladWydrukuToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.PodgladWydrukuToolStripMenuItem.Text = "Podglad wydruku";
            // 
            // NarzędziaToolStripMenuItem
            // 
            this.NarzędziaToolStripMenuItem.Checked = true;
            this.NarzędziaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.NarzędziaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DodajWartośćToolStripMenuItem1,
            this.ZmieńWartośćToolStripMenuItem1,
            this.UsuńWartośćToolStripMenuItem});
            this.NarzędziaToolStripMenuItem.Name = "NarzędziaToolStripMenuItem";
            this.NarzędziaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.NarzędziaToolStripMenuItem.Text = "&Edycja";
            // 
            // DodajWartośćToolStripMenuItem1
            // 
            this.DodajWartośćToolStripMenuItem1.Name = "DodajWartośćToolStripMenuItem1";
            this.DodajWartośćToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.DodajWartośćToolStripMenuItem1.Text = "&Dodaj wartość";
            // 
            // ZmieńWartośćToolStripMenuItem1
            // 
            this.ZmieńWartośćToolStripMenuItem1.Name = "ZmieńWartośćToolStripMenuItem1";
            this.ZmieńWartośćToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.ZmieńWartośćToolStripMenuItem1.Text = "&Zmień wartość";
            // 
            // UsuńWartośćToolStripMenuItem
            // 
            this.UsuńWartośćToolStripMenuItem.Name = "UsuńWartośćToolStripMenuItem";
            this.UsuńWartośćToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.UsuńWartośćToolStripMenuItem.Text = "Usuń wartość";
            // 
            // WyświetlStatystykiToolStripMenuItem
            // 
            this.WyświetlStatystykiToolStripMenuItem.Name = "WyświetlStatystykiToolStripMenuItem";
            this.WyświetlStatystykiToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.WyświetlStatystykiToolStripMenuItem.Text = "&Widok";
            // 
            // kategorieToolStripMenuItem
            // 
            this.kategorieToolStripMenuItem.Name = "kategorieToolStripMenuItem";
            this.kategorieToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.kategorieToolStripMenuItem.Text = "&Pomoc";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.toolStripLabel8,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripLabel2,
            this.toolStripButton3,
            this.toolStripLabel3,
            this.toolStripButton4,
            this.toolStripLabel4,
            this.WyszukajButton,
            this.toolStripLabel5,
            this.toolStripButton6,
            this.toolStripLabel6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1412, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(84, 24);
            this.toolStripLabel8.Text = "Użytkownik";
            this.toolStripLabel8.Click += new System.EventHandler(this.toolStripLabel8_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabel1.Text = "Dodaj";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabel2.Text = "Edytuj";
            this.toolStripLabel2.Click += new System.EventHandler(this.EditOperation_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(41, 24);
            this.toolStripLabel3.Text = "Usuń";
            this.toolStripLabel3.Click += new System.EventHandler(this.DeleteOperation_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(52, 24);
            this.toolStripLabel4.Text = "Drukuj";
            // 
            // WyszukajButton
            // 
            this.WyszukajButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.WyszukajButton.Image = ((System.Drawing.Image)(resources.GetObject("WyszukajButton.Image")));
            this.WyszukajButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WyszukajButton.Name = "WyszukajButton";
            this.WyszukajButton.Size = new System.Drawing.Size(24, 24);
            this.WyszukajButton.Text = "toolStripButton5";
            this.WyszukajButton.Click += new System.EventHandler(this.WyszukajButton_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(70, 24);
            this.toolStripLabel5.Text = "Wyszukaj";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(65, 24);
            this.toolStripLabel6.Text = "Odśwież";
            // 
            // operacjeBindingSource
            // 
            this.operacjeBindingSource.DataMember = "operacje";
            this.operacjeBindingSource.DataSource = this.baza_danychDataSet;
            // 
            // baza_danychDataSet
            // 
            this.baza_danychDataSet.DataSetName = "baza_danychDataSet";
            this.baza_danychDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operacjeTableAdapter
            // 
            this.operacjeTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tW_kategorie, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.splitContainer2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.12524F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.87476F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(259, 519);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tW_kategorie
            // 
            this.tW_kategorie.CheckBoxes = true;
            this.tW_kategorie.ContextMenuStrip = this.MenuKateogrii;
            this.tW_kategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tW_kategorie.HideSelection = false;
            this.tW_kategorie.Location = new System.Drawing.Point(3, 340);
            this.tW_kategorie.Name = "tW_kategorie";
            this.tW_kategorie.Size = new System.Drawing.Size(253, 176);
            this.tW_kategorie.TabIndex = 1;
            this.tW_kategorie.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tW_kategorie_AfterCheck);
            // 
            // MenuKateogrii
            // 
            this.MenuKateogrii.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuKateogrii.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.zmieńToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.MenuKateogrii.Name = "contextMenuStrip1";
            this.MenuKateogrii.Size = new System.Drawing.Size(121, 76);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // zmieńToolStripMenuItem
            // 
            this.zmieńToolStripMenuItem.Name = "zmieńToolStripMenuItem";
            this.zmieńToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.zmieńToolStripMenuItem.Text = "Zmień";
            this.zmieńToolStripMenuItem.Click += new System.EventHandler(this.zmieńToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.usuńToolStripMenuItem.Text = "Usuń";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tW_daty);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tW_users);
            this.splitContainer2.Size = new System.Drawing.Size(253, 331);
            this.splitContainer2.SplitterDistance = 218;
            this.splitContainer2.TabIndex = 2;
            // 
            // tW_daty
            // 
            this.tW_daty.CheckBoxes = true;
            this.tW_daty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tW_daty.HideSelection = false;
            this.tW_daty.Location = new System.Drawing.Point(0, 0);
            this.tW_daty.Name = "tW_daty";
            this.tW_daty.Size = new System.Drawing.Size(253, 218);
            this.tW_daty.TabIndex = 0;
            this.tW_daty.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tW_daty_AfterCheck);
            // 
            // tW_users
            // 
            this.tW_users.CheckBoxes = true;
            this.tW_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tW_users.Location = new System.Drawing.Point(0, 0);
            this.tW_users.Name = "tW_users";
            this.tW_users.Size = new System.Drawing.Size(253, 109);
            this.tW_users.TabIndex = 0;
            this.tW_users.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tW_users_AfterCheck);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.76771F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.23229F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1412, 525);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(268, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LV_operacje);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewOperations);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(1141, 519);
            this.splitContainer1.SplitterDistance = 408;
            this.splitContainer1.TabIndex = 2;
            // 
            // LV_operacje
            // 
            this.LV_operacje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderData,
            this.columnHeaderKwota,
            this.columnHeaderUzytkownik,
            this.columnHeaderTyp,
            this.columnHeaderKategoria,
            this.columnHeaderPodkategoria,
            this.columnHeaderForma,
            this.columnHeaderOpis});
            this.LV_operacje.Cursor = System.Windows.Forms.Cursors.Default;
            this.LV_operacje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_operacje.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LV_operacje.FullRowSelect = true;
            this.LV_operacje.GridLines = true;
            this.LV_operacje.HideSelection = false;
            this.LV_operacje.Location = new System.Drawing.Point(0, 0);
            this.LV_operacje.Name = "LV_operacje";
            this.LV_operacje.Size = new System.Drawing.Size(1141, 408);
            this.LV_operacje.TabIndex = 4;
            this.LV_operacje.UseCompatibleStateImageBehavior = false;
            this.LV_operacje.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "Id";
            this.columnHeaderID.Width = 30;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderData.Width = 100;
            // 
            // columnHeaderKwota
            // 
            this.columnHeaderKwota.Text = "Kwota";
            this.columnHeaderKwota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderKwota.Width = 120;
            // 
            // columnHeaderUzytkownik
            // 
            this.columnHeaderUzytkownik.Text = "Użytkownik";
            this.columnHeaderUzytkownik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderUzytkownik.Width = 150;
            // 
            // columnHeaderTyp
            // 
            this.columnHeaderTyp.Text = "Typ";
            this.columnHeaderTyp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTyp.Width = 100;
            // 
            // columnHeaderKategoria
            // 
            this.columnHeaderKategoria.Text = "Kategoria";
            this.columnHeaderKategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderKategoria.Width = 135;
            // 
            // columnHeaderPodkategoria
            // 
            this.columnHeaderPodkategoria.Text = "Podkategoria";
            this.columnHeaderPodkategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPodkategoria.Width = 135;
            // 
            // columnHeaderForma
            // 
            this.columnHeaderForma.Text = "Forma płatności";
            this.columnHeaderForma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderForma.Width = 120;
            // 
            // columnHeaderOpis
            // 
            this.columnHeaderOpis.Text = "Opis";
            this.columnHeaderOpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderOpis.Width = 230;
            // 
            // dataGridViewOperations
            // 
            this.dataGridViewOperations.AutoGenerateColumns = false;
            this.dataGridViewOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idoperacjiDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.kwotaDataGridViewTextBoxColumn,
            this.idkategoriaDataGridViewTextBoxColumn,
            this.iduzytkownikaDataGridViewTextBoxColumn,
            this.idformaplatnosciDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridViewOperations.DataSource = this.operacjeBindingSource;
            this.dataGridViewOperations.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOperations.Name = "dataGridViewOperations";
            this.dataGridViewOperations.RowTemplate.Height = 24;
            this.dataGridViewOperations.Size = new System.Drawing.Size(506, 410);
            this.dataGridViewOperations.TabIndex = 3;
            // 
            // idoperacjiDataGridViewTextBoxColumn
            // 
            this.idoperacjiDataGridViewTextBoxColumn.DataPropertyName = "id_operacji";
            this.idoperacjiDataGridViewTextBoxColumn.HeaderText = "id_operacji";
            this.idoperacjiDataGridViewTextBoxColumn.Name = "idoperacjiDataGridViewTextBoxColumn";
            this.idoperacjiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // kwotaDataGridViewTextBoxColumn
            // 
            this.kwotaDataGridViewTextBoxColumn.DataPropertyName = "kwota";
            this.kwotaDataGridViewTextBoxColumn.HeaderText = "kwota";
            this.kwotaDataGridViewTextBoxColumn.Name = "kwotaDataGridViewTextBoxColumn";
            // 
            // idkategoriaDataGridViewTextBoxColumn
            // 
            this.idkategoriaDataGridViewTextBoxColumn.DataPropertyName = "id_kategoria";
            this.idkategoriaDataGridViewTextBoxColumn.HeaderText = "id_kategoria";
            this.idkategoriaDataGridViewTextBoxColumn.Name = "idkategoriaDataGridViewTextBoxColumn";
            // 
            // iduzytkownikaDataGridViewTextBoxColumn
            // 
            this.iduzytkownikaDataGridViewTextBoxColumn.DataPropertyName = "id_uzytkownika";
            this.iduzytkownikaDataGridViewTextBoxColumn.HeaderText = "id_uzytkownika";
            this.iduzytkownikaDataGridViewTextBoxColumn.Name = "iduzytkownikaDataGridViewTextBoxColumn";
            // 
            // idformaplatnosciDataGridViewTextBoxColumn
            // 
            this.idformaplatnosciDataGridViewTextBoxColumn.DataPropertyName = "id_forma_platnosci";
            this.idformaplatnosciDataGridViewTextBoxColumn.HeaderText = "id_forma_platnosci";
            this.idformaplatnosciDataGridViewTextBoxColumn.Name = "idformaplatnosciDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 107);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1130, 70);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wykres kołowy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s2";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1124, 64);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1130, 78);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wykres liniowy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Przychody";
            legend3.Name = "Wydatki";
            this.chart2.Legends.Add(legend2);
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Przychody";
            series2.Name = "Wydatki";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Przychody";
            series3.Name = "Przychody";
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(1124, 72);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1130, 78);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Wykres kolumnowy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart3.Location = new System.Drawing.Point(0, 0);
            this.chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.Name = "s1";
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(1130, 78);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 107);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // FormualrzGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuGłówne);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormualrzGlowny";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.FormualrzGlowny_Load);
            this.menuGłówne.ResumeLayout(false);
            this.menuGłówne.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operacjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_danychDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.MenuKateogrii.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperations)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.MenuStrip menuGłówne;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ZamknijToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DrukujToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PodgladWydrukuToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem NarzędziaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DodajWartośćToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ZmieńWartośćToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem UsuńWartośćToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem WyświetlStatystykiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton WyszukajButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
		private baza_danychDataSet baza_danychDataSet;
		private System.Windows.Forms.BindingSource operacjeBindingSource;
		private baza_danychDataSetTableAdapters.operacjeTableAdapter operacjeTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView tW_daty;
        private System.Windows.Forms.TreeView tW_kategorie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewOperations;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoperacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduzytkownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idformaplatnosciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView LV_operacje;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderKwota;
        private System.Windows.Forms.ColumnHeader columnHeaderUzytkownik;
        private System.Windows.Forms.ColumnHeader columnHeaderTyp;
        private System.Windows.Forms.ColumnHeader columnHeaderKategoria;
        private System.Windows.Forms.ColumnHeader columnHeaderPodkategoria;
        private System.Windows.Forms.ColumnHeader columnHeaderForma;
        private System.Windows.Forms.ContextMenuStrip MenuKateogrii;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.ColumnHeader columnHeaderOpis;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tW_users;
    }
}

