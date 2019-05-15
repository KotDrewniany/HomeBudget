using budzet_domowy.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Decimal;

namespace budzet_domowy
{
	public partial class FormularzDodaj : Form
	{
		public FormualrzGlowny MainForm { get; set; }
		public int OtwartyUcDodajKategorie { get; set; }
		public int EditedId { get; set; }
		public bool IsEditMode => EditedId != 0;
		public OperationDto OperationDto { get; set; }

		public FormularzDodaj(FormualrzGlowny mainForm)
		{
			InitializeComponent();
			InitializeComboBoxes();
			radioButtonExpense.Checked = true;
			MainForm = mainForm;
		}

		public void SetEditedItem(int editedId)
		{
			EditedId = editedId;
			if (IsEditMode)
				ReadEditedOperation();
			else
				ResetForm();
		}

		private void ReadEditedOperation()
		{
			using (var context = new DataClasses2DataContext())
			{
				var operation = context.operacje.FirstOrDefault(x => x.id_operacji == EditedId);
				if (operation == null)
					throw new ArgumentException("No operation with given id in the database");

				OperationDto = new OperationDto()
				{
					Id = operation.id_operacji,
					Data = operation.data,
					Price = operation.kwota,
					CategoryId = operation.id_kategoria,
					UserId = operation.id_uzytkownika,
					PaymentFormId = operation.id_forma_platnosci,
					Description = operation.opis,
				};
			}
			SetEditedOperationData();
		}

		private void SetEditedOperationData()
		{
            comboBoxUsers.SelectedIndex = OperationDto.UserId;
            comboBoxCategory.SelectedValue = OperationDto.CategoryId;
            //comboBoxSubcategory.SelectedValue = OperationDto.PodcategoryId;
            dateTimePickerDate.Value = OperationDto.Data;
            //radiobuttonexpense.checked = ;
            comboBoxOperationForm.SelectedValue = OperationDto.PaymentFormId;
            //comboboxoperationform.text = ;
            textBoxPrice.Text = OperationDto.Price.ToString("0.00");
        }

		private void InitializeComboBoxes() 
		{
			using (var context = new DataClasses2DataContext())
			{
				var users = context.uzytkownicy.Select(x => new ComboboxModel
				{ DisplayMember = x.imie + x.nazwisko, Id = x.id_uzytkownika }).ToArray();
				var categories = context.kategoria.Where(x => x.id_nadkategoria == null).Select(x => new ComboboxModel
				{ DisplayMember = x.nazwa, Id = x.id_kategoria }).ToArray();
                var operationForms = context.forma_platnosci.Select(x => new ComboboxModel
				{ DisplayMember = x.nazwa, Id = x.id_forma_platnosci }).ToArray();

				comboBoxUsers.Items.AddRange(users);
				comboBoxCategory.Items.AddRange(categories);
                comboBoxOperationForm.Items.AddRange(operationForms);
			}
			comboBoxUsers.DisplayMember = "DisplayMember";
			comboBoxUsers.ValueMember = "Id";

			comboBoxCategory.DisplayMember = "DisplayMember";
			comboBoxCategory.ValueMember = "Id";

			comboBoxSubcategory.DisplayMember = "DisplayMember";
			comboBoxSubcategory.ValueMember = "Id";

			comboBoxOperationForm.DisplayMember = "DisplayMember";
			comboBoxOperationForm.ValueMember = "Id";

			wczytaj_kategorie();
		}

        public void wczytaj_kategorie()
        {
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			using (var context = new DataClasses2DataContext())
			{
				var userId = comboBoxUsers.SelectedIndex != -1
					? ((ComboboxModel)comboBoxUsers.Items[comboBoxUsers.SelectedIndex]).Id
					: 0;
				var categoryId = comboBoxCategory.SelectedIndex != -1
					? ((ComboboxModel)comboBoxCategory.Items[comboBoxCategory.SelectedIndex]).Id
					: 0;
				var subcategoryId = comboBoxSubcategory.SelectedIndex != -1
					? ((ComboboxModel)comboBoxSubcategory.Items[comboBoxSubcategory.SelectedIndex]).Id
					: 0;
				var operationFormId = comboBoxOperationForm.SelectedIndex != -1
					? ((ComboboxModel)comboBoxOperationForm.Items[comboBoxOperationForm.SelectedIndex]).Id
					: 0;

				if (IsEditMode)
				{
					var operation = context.operacje.FirstOrDefault(x => x.id_operacji == OperationDto.Id);
					if (operation != null)
					{
						operation.data = dateTimePickerDate.Value;
						operation.kwota = TryParse(textBoxPrice.Text, out var price) ? price : 0;
						operation.id_uzytkownika = userId;
						operation.id_kategoria = categoryId;
                        operation.id_forma_platnosci = operationFormId;
						operation.opis = richTextBoxDescription.Text;
					}
				}
				else
				{
					context.operacje.InsertOnSubmit(new operacje()
					{
						data = dateTimePickerDate.Value,
						kwota = TryParse(textBoxPrice.Text, out var price) ? price : 0,
						id_uzytkownika = userId,
						id_kategoria = categoryId,
						id_forma_platnosci = operationFormId,
						opis = richTextBoxDescription.Text
					});
				}
                context.SubmitChanges();
			}
			MainForm.UpdateOperationList(); // ghfhfhgfhfhgfhgfhfhgfgh
            MainForm.stworz_liste();
			Close();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		public void ResetForm()
		{
			comboBoxUsers.SelectedIndex = -1;
			comboBoxCategory.SelectedIndex = -1;
			comboBoxSubcategory.SelectedIndex = -1;
			dateTimePickerDate.Value = DateTime.Now;
			radioButtonExpense.Checked = true;
			comboBoxOperationForm.Text = "";
			textBoxPrice.Text = "";
			richTextBoxDescription.Text = "";
		}

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new DataClasses2DataContext())
            {
                comboBoxSubcategory.SelectedIndex = -1;
                comboBoxSubcategory.Items.Clear();

                if (comboBoxCategory.SelectedIndex != -1)
                {
                    var selectedItem = (ComboboxModel)comboBoxCategory.Items[comboBoxCategory.SelectedIndex];
                    var subcategories = context.kategoria.Where(x => x.id_nadkategoria.Value == selectedItem.Id).Select(x => new ComboboxModel
                        { DisplayMember = x.nazwa, Id = x.id_kategoria }).ToArray();

                    comboBoxSubcategory.Items.AddRange(subcategories);
                }
            }
        }
    }
}