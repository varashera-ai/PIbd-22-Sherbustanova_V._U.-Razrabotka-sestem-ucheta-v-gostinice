using System;
using System.Windows.Forms;
using Unity;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting
{
    public partial class FormBookings : Form
    {
        private readonly IUnityContainer _container;
        private readonly IBookingRepository _bookingRepository;

        public FormBookings(IUnityContainer container, IBookingRepository bookingRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _bookingRepository = bookingRepository ?? throw new ArgumentNullException(nameof(bookingRepository));
            this.Load += FormBookings_Load;
        }

        private void FormBookings_Load(object sender, EventArgs e)
        {
            try { LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadList() => dataGridViewData.DataSource = _bookingRepository.ReadBookings();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormBooking>().ShowDialog(); LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}