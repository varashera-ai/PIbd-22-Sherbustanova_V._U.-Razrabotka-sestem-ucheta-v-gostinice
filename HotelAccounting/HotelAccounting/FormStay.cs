using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting
{
    public partial class FormStay : Form
    {
        private readonly IStayRepository _stayRepository;
        private readonly IGuestRepository _guestRepository;
        private readonly IRoomRepository _roomRepository; 
        private readonly IServiceRepository _serviceRepository;

        public FormStay(IStayRepository stayRepository, IGuestRepository guestRepository,
                        IRoomRepository roomRepository, IServiceRepository serviceRepository)
        {
            InitializeComponent();
            _stayRepository = stayRepository ?? throw new ArgumentNullException(nameof(stayRepository));
            _guestRepository = guestRepository ?? throw new ArgumentNullException(nameof(guestRepository));
            _roomRepository = roomRepository ?? throw new ArgumentNullException(nameof(roomRepository));
            _serviceRepository = serviceRepository ?? throw new ArgumentNullException(nameof(serviceRepository));

            comboBoxGuest.DataSource = _guestRepository.ReadGuests();
            comboBoxGuest.DisplayMember = "FullName";
            comboBoxGuest.ValueMember = "Id";

            comboBoxRoom.DataSource = _roomRepository.ReadRooms();
            comboBoxRoom.DisplayMember = "RoomNumber";
            comboBoxRoom.ValueMember = "Id";

            var services = _serviceRepository.ReadServices();
            var columnService = (DataGridViewComboBoxColumn)dataGridViewServices.Columns["ColumnService"];
            columnService.DataSource = services;
            columnService.DisplayMember = "Name";
            columnService.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxGuest.SelectedIndex < 0 || comboBoxRoom.SelectedIndex < 0)
                    throw new Exception("Выберите гостя и номер");

                var stayServices = CreateListStayServicesFromDataGrid();

                var stay = Stay.CreateOperation(0,
                    (int)comboBoxGuest.SelectedValue!,
                    (int)comboBoxRoom.SelectedValue!,
                    stayServices);

                _stayRepository.CreateStay(stay);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<StayService> CreateListStayServicesFromDataGrid()
        {
            var list = new List<StayService>();
            foreach (DataGridViewRow row in dataGridViewServices.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["ColumnService"].Value == null || row.Cells["ColumnQuantity"].Value == null) continue;

                var serviceId = Convert.ToInt32(row.Cells["ColumnService"].Value);
                var quantity = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);

                if (quantity <= 0) throw new Exception("Количество услуг должно быть больше нуля");

                list.Add(StayService.CreateElement(0, 0, serviceId, quantity));
            }
            return list;
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}