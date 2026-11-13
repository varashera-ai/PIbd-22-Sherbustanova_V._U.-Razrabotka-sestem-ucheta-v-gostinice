using System;
using System.Windows.Forms;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting
{
    public partial class FormBooking : Form
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IGuestRepository _guestRepository;
        private readonly IRoomRepository _roomRepository;

        public FormBooking(IBookingRepository bookingRepository, IGuestRepository guestRepository, IRoomRepository roomRepository)
        {
            InitializeComponent();
            _bookingRepository = bookingRepository ?? throw new ArgumentNullException(nameof(bookingRepository));
            _guestRepository = guestRepository ?? throw new ArgumentNullException(nameof(guestRepository));
            _roomRepository = roomRepository ?? throw new ArgumentNullException(nameof(roomRepository));
            this.Load += FormBooking_Load;
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxGuest.DataSource = _guestRepository.ReadGuests();
                comboBoxGuest.DisplayMember = "FullName";
                comboBoxGuest.ValueMember = "Id";

                comboBoxRoom.DataSource = _roomRepository.ReadRooms();
                comboBoxRoom.DisplayMember = "RoomNumber";
                comboBoxRoom.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxGuest.SelectedIndex < 0 || comboBoxRoom.SelectedIndex < 0)
                    throw new Exception("Выберите гостя и номер");

                if (dateTimePickerCheckIn.Value >= dateTimePickerCheckOut.Value)
                    throw new Exception("Дата выезда должна быть позже даты заезда");

                _bookingRepository.CreateBooking(Booking.CreateOperation(0,
                    (int)comboBoxGuest.SelectedValue!,
                    (int)comboBoxRoom.SelectedValue!,
                    dateTimePickerCheckIn.Value.ToUniversalTime(),
                    dateTimePickerCheckOut.Value.ToUniversalTime()));
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}