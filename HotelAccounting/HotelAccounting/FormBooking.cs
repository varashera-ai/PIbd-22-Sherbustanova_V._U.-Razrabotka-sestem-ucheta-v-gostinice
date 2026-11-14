using System;
using System.Windows.Forms;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting
{
    public partial class FormBooking : Form
    {
        private readonly IBookingRepository _bookingRepository;

        public FormBooking(IBookingRepository bookingRepository, IGuestRepository guestRepository, IRoomRepository roomRepository)
        {
            InitializeComponent();
            _bookingRepository = bookingRepository ?? throw new ArgumentNullException(nameof(bookingRepository));

            comboBoxGuest.DataSource = guestRepository.ReadGuests();
            comboBoxGuest.DisplayMember = "FullName";
            comboBoxGuest.ValueMember = "Id";

            comboBoxRoom.DataSource = roomRepository.ReadRooms();
            comboBoxRoom.DisplayMember = "RoomNumber";
            comboBoxRoom.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxGuest.SelectedIndex < 0 || comboBoxRoom.SelectedIndex < 0)
                    throw new Exception("Выберите гостя и номер");

                if (dateTimePickerCheckIn.Value >= dateTimePickerCheckOut.Value)
                    throw new Exception("Дата выезда должна быть позже");

                _bookingRepository.CreateBooking(Booking.CreateOperation(0,
                    (int)comboBoxGuest.SelectedValue!,
                    (int)comboBoxRoom.SelectedValue!,
                    dateTimePickerCheckIn.Value,
                    dateTimePickerCheckOut.Value));
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}