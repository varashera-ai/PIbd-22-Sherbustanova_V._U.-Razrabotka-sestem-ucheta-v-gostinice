using System;
using System.Windows.Forms;
using HotelAccounting.Enums;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting
{
    public partial class FormRoom : Form
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IRoomCategoryRepository _categoryRepository;
        private int? _roomId;

        public int Id
        {
            set
            {
                try
                {
                    var room = _roomRepository.ReadRoomById(value);
                    if (room == null) throw new InvalidOperationException("Номер не найден");

                    numericUpDownRoomNumber.Value = room.RoomNumber;
                    numericUpDownFloor.Value = room.Floor;
                    comboBoxStatus.SelectedItem = room.Status;
                    comboBoxCategory.SelectedValue = room.CategoryId;

                    _roomId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        public FormRoom(IRoomRepository roomRepository, IRoomCategoryRepository categoryRepository)
        {
            InitializeComponent();
            _roomRepository = roomRepository ?? throw new ArgumentNullException(nameof(roomRepository));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));

            comboBoxStatus.DataSource = Enum.GetValues(typeof(RoomStatus));

            comboBoxCategory.DataSource = _categoryRepository.ReadRoomCategories().ToList();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxStatus.SelectedIndex < 1 || comboBoxCategory.SelectedIndex < 1)
                    throw new Exception("Имеются незаполненные поля");

                var status = (RoomStatus)comboBoxStatus.SelectedItem!;
                var categoryId = (int)comboBoxCategory.SelectedValue!;

                if (_roomId.HasValue)
                {
                    var room = Room.CreateEntity(_roomId.Value, (int)numericUpDownRoomNumber.Value, (int)numericUpDownFloor.Value, status, categoryId);
                    _roomRepository.UpdateRoom(room);
                }
                else
                {
                    var room = Room.CreateEntity(0, (int)numericUpDownRoomNumber.Value, (int)numericUpDownFloor.Value, status, categoryId);
                    _roomRepository.CreateRoom(room);
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