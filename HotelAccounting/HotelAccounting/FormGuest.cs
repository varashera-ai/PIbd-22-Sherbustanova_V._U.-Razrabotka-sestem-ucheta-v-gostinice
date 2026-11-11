using System;
using System.Windows.Forms;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting
{
    public partial class FormGuest : Form
    {
        private readonly IGuestRepository _guestRepository;
        private int? _guestId;

        public int Id
        {
            set
            {
                try
                {
                    var guest = _guestRepository.ReadGuestById(value);
                    if (guest == null) throw new Exception("Гость не найден");
                    textBoxFullName.Text = guest.FullName;
                    textBoxPassport.Text = guest.PassportNumber;
                    textBoxPhone.Text = guest.Phone;
                    checkBoxIsRegular.Checked = guest.IsRegularClient;
                    _guestId = value;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); Close(); }
            }
        }

        public FormGuest(IGuestRepository guestRepository)
        {
            InitializeComponent();
            _guestRepository = guestRepository ?? throw new ArgumentNullException(nameof(guestRepository));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFullName.Text) || string.IsNullOrWhiteSpace(textBoxPassport.Text))
                    throw new Exception("Заполните ФИО и Паспорт");

                if (_guestId.HasValue)
                    _guestRepository.UpdateGuest(Guest.CreateEntity(_guestId.Value, textBoxFullName.Text, textBoxPassport.Text, textBoxPhone.Text, checkBoxIsRegular.Checked));
                else
                    _guestRepository.CreateGuest(Guest.CreateEntity(0, textBoxFullName.Text, textBoxPassport.Text, textBoxPhone.Text, checkBoxIsRegular.Checked));
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}