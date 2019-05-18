namespace budzet_domowy
{
    partial class FormularzDodaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.comboBoxSubcategory = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxOperationForm = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonIncome = new System.Windows.Forms.RadioButton();
            this.radioButtonExpense = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAddEdit = new System.Windows.Forms.Label();
            this.labelWybierzUzytkownika = new System.Windows.Forms.Label();
            this.labelWybierzPłatność = new System.Windows.Forms.Label();
            this.labelWybierzKategorie = new System.Windows.Forms.Label();
            this.labelWybierzPodkategorie = new System.Windows.Forms.Label();
            this.labelWpiszKwote = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelWpiszLiczby = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(30, 519);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(313, 58);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "ZAPISZ";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(368, 519);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(313, 58);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.zmieńToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 76);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // zmieńToolStripMenuItem
            // 
            this.zmieńToolStripMenuItem.Name = "zmieńToolStripMenuItem";
            this.zmieńToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.zmieńToolStripMenuItem.Text = "Zmień";
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.usuńToolStripMenuItem.Text = "Usuń";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(62, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 75;
            this.label11.Text = "Użytkownik";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(199, 83);
            this.comboBoxUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(257, 24);
            this.comboBoxUsers.TabIndex = 74;
            // 
            // comboBoxSubcategory
            // 
            this.comboBoxSubcategory.FormattingEnabled = true;
            this.comboBoxSubcategory.Location = new System.Drawing.Point(199, 274);
            this.comboBoxSubcategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSubcategory.Name = "comboBoxSubcategory";
            this.comboBoxSubcategory.Size = new System.Drawing.Size(257, 24);
            this.comboBoxSubcategory.TabIndex = 73;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(199, 236);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(257, 24);
            this.comboBoxCategory.TabIndex = 72;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // comboBoxOperationForm
            // 
            this.comboBoxOperationForm.FormattingEnabled = true;
            this.comboBoxOperationForm.Location = new System.Drawing.Point(199, 198);
            this.comboBoxOperationForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxOperationForm.Name = "comboBoxOperationForm";
            this.comboBoxOperationForm.Size = new System.Drawing.Size(257, 24);
            this.comboBoxOperationForm.TabIndex = 71;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(199, 313);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(257, 22);
            this.textBoxPrice.TabIndex = 70;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(199, 358);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(382, 136);
            this.richTextBoxDescription.TabIndex = 69;
            this.richTextBoxDescription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(49, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "Podkategoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(75, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Kategoria";
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Location = new System.Drawing.Point(368, 158);
            this.radioButtonIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Size = new System.Drawing.Size(88, 21);
            this.radioButtonIncome.TabIndex = 66;
            this.radioButtonIncome.TabStop = true;
            this.radioButtonIncome.Text = "Przychód";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            // 
            // radioButtonExpense
            // 
            this.radioButtonExpense.AutoSize = true;
            this.radioButtonExpense.Location = new System.Drawing.Point(199, 160);
            this.radioButtonExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonExpense.Name = "radioButtonExpense";
            this.radioButtonExpense.Size = new System.Drawing.Size(84, 21);
            this.radioButtonExpense.TabIndex = 65;
            this.radioButtonExpense.TabStop = true;
            this.radioButtonExpense.Text = "Wydatek";
            this.radioButtonExpense.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(199, 122);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(257, 22);
            this.dateTimePickerDate.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(110, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(70, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Kwota (zł)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(81, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Płatność";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(119, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Typ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(110, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Data";
            // 
            // labelAddEdit
            // 
            this.labelAddEdit.AutoSize = true;
            this.labelAddEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddEdit.Location = new System.Drawing.Point(194, 24);
            this.labelAddEdit.Name = "labelAddEdit";
            this.labelAddEdit.Size = new System.Drawing.Size(258, 28);
            this.labelAddEdit.TabIndex = 58;
            this.labelAddEdit.Text = "Dane ogólne operacji";
            // 
            // labelWybierzUzytkownika
            // 
            this.labelWybierzUzytkownika.AutoSize = true;
            this.labelWybierzUzytkownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWybierzUzytkownika.ForeColor = System.Drawing.Color.Red;
            this.labelWybierzUzytkownika.Location = new System.Drawing.Point(496, 87);
            this.labelWybierzUzytkownika.Name = "labelWybierzUzytkownika";
            this.labelWybierzUzytkownika.Size = new System.Drawing.Size(165, 20);
            this.labelWybierzUzytkownika.TabIndex = 76;
            this.labelWybierzUzytkownika.Text = "Wybierz użytkownika";
            this.labelWybierzUzytkownika.Visible = false;
            // 
            // labelWybierzPłatność
            // 
            this.labelWybierzPłatność.AutoSize = true;
            this.labelWybierzPłatność.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWybierzPłatność.ForeColor = System.Drawing.Color.Red;
            this.labelWybierzPłatność.Location = new System.Drawing.Point(496, 198);
            this.labelWybierzPłatność.Name = "labelWybierzPłatność";
            this.labelWybierzPłatność.Size = new System.Drawing.Size(138, 20);
            this.labelWybierzPłatność.TabIndex = 77;
            this.labelWybierzPłatność.Text = "Wybierz płatność";
            this.labelWybierzPłatność.Visible = false;
            // 
            // labelWybierzKategorie
            // 
            this.labelWybierzKategorie.AutoSize = true;
            this.labelWybierzKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWybierzKategorie.ForeColor = System.Drawing.Color.Red;
            this.labelWybierzKategorie.Location = new System.Drawing.Point(499, 236);
            this.labelWybierzKategorie.Name = "labelWybierzKategorie";
            this.labelWybierzKategorie.Size = new System.Drawing.Size(143, 20);
            this.labelWybierzKategorie.TabIndex = 78;
            this.labelWybierzKategorie.Text = "Wybierz kategorię";
            this.labelWybierzKategorie.Visible = false;
            // 
            // labelWybierzPodkategorie
            // 
            this.labelWybierzPodkategorie.AutoSize = true;
            this.labelWybierzPodkategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWybierzPodkategorie.ForeColor = System.Drawing.Color.Red;
            this.labelWybierzPodkategorie.Location = new System.Drawing.Point(499, 274);
            this.labelWybierzPodkategorie.Name = "labelWybierzPodkategorie";
            this.labelWybierzPodkategorie.Size = new System.Drawing.Size(170, 20);
            this.labelWybierzPodkategorie.TabIndex = 79;
            this.labelWybierzPodkategorie.Text = "Wybierz podkategorię";
            this.labelWybierzPodkategorie.Visible = false;
            // 
            // labelWpiszKwote
            // 
            this.labelWpiszKwote.AutoSize = true;
            this.labelWpiszKwote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWpiszKwote.ForeColor = System.Drawing.Color.Red;
            this.labelWpiszKwote.Location = new System.Drawing.Point(499, 313);
            this.labelWpiszKwote.Name = "labelWpiszKwote";
            this.labelWpiszKwote.Size = new System.Drawing.Size(104, 20);
            this.labelWpiszKwote.TabIndex = 80;
            this.labelWpiszKwote.Text = "Wpisz kwotę";
            this.labelWpiszKwote.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::budzet_domowy.Properties.Resources.exclamation_40026_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(462, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::budzet_domowy.Properties.Resources.exclamation_40026_960_720;
            this.pictureBox2.Location = new System.Drawing.Point(462, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::budzet_domowy.Properties.Resources.exclamation_40026_960_720;
            this.pictureBox3.Location = new System.Drawing.Point(462, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::budzet_domowy.Properties.Resources.exclamation_40026_960_720;
            this.pictureBox4.Location = new System.Drawing.Point(462, 270);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 84;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::budzet_domowy.Properties.Resources.exclamation_40026_960_720;
            this.pictureBox5.Location = new System.Drawing.Point(462, 309);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 85;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // labelWpiszLiczby
            // 
            this.labelWpiszLiczby.AutoSize = true;
            this.labelWpiszLiczby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWpiszLiczby.ForeColor = System.Drawing.Color.Red;
            this.labelWpiszLiczby.Location = new System.Drawing.Point(499, 313);
            this.labelWpiszLiczby.Name = "labelWpiszLiczby";
            this.labelWpiszLiczby.Size = new System.Drawing.Size(105, 20);
            this.labelWpiszLiczby.TabIndex = 86;
            this.labelWpiszLiczby.Text = "Wpisz liczbę";
            this.labelWpiszLiczby.Visible = false;
            // 
            // FormularzDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 599);
            this.Controls.Add(this.labelWpiszLiczby);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelWpiszKwote);
            this.Controls.Add(this.labelWybierzPodkategorie);
            this.Controls.Add(this.labelWybierzKategorie);
            this.Controls.Add(this.labelWybierzPłatność);
            this.Controls.Add(this.labelWybierzUzytkownika);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.comboBoxSubcategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxOperationForm);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButtonIncome);
            this.Controls.Add(this.radioButtonExpense);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAddEdit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularzDodaj";
            this.Text = "FormularzDodaj";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.ComboBox comboBoxSubcategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxOperationForm;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonIncome;
        private System.Windows.Forms.RadioButton radioButtonExpense;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAddEdit;
        private System.Windows.Forms.Label labelWybierzUzytkownika;
        private System.Windows.Forms.Label labelWybierzPłatność;
        private System.Windows.Forms.Label labelWybierzKategorie;
        private System.Windows.Forms.Label labelWybierzPodkategorie;
        private System.Windows.Forms.Label labelWpiszKwote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelWpiszLiczby;
    }
}