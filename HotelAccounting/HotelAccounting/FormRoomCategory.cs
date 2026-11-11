using System;
using System.Windows.Forms;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting
{
    public partial class FormRoomCategory : Form
    {
        private readonly IRoomCategoryRepository _categoryRepository;
        private int? _categoryId;

        public int Id
        {
            set
            {
                try
                {
                    var category = _categoryRepository.ReadRoomCategoryById(value);
                    if (category == null) throw new InvalidOperationException("Категория не найдена");

                    textBoxName.Text = category.Name;
                    numericUpDownCapacity.Value = category.Capacity;
                    numericUpDownPrice.Value = category.PricePerNight;

                    _categoryId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        public FormRoomCategory(IRoomCategoryRepository categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                    throw new Exception("Имеются незаполненные поля");

                if (_categoryId.HasValue)
                {
                    var category = RoomCategory.CreateEntity(_categoryId.Value, textBoxName.Text,
                        (int)numericUpDownCapacity.Value, numericUpDownPrice.Value);
                    _categoryRepository.UpdateRoomCategory(category);
                }
                else
                {
                    var category = RoomCategory.CreateEntity(0, textBoxName.Text,
                        (int)numericUpDownCapacity.Value, numericUpDownPrice.Value);
                    _categoryRepository.CreateRoomCategory(category);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}