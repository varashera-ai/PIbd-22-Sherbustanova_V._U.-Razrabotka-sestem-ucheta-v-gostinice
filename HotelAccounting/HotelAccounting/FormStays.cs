using System;
using System.Windows.Forms;
using Unity;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting
{
    public partial class FormStays : Form
    {
        private readonly IUnityContainer _container;
        private readonly IStayRepository _stayRepository;

        public FormStays(IUnityContainer container, IStayRepository stayRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _stayRepository = stayRepository ?? throw new ArgumentNullException(nameof(stayRepository));
        }

        private void FormStays_Load(object sender, EventArgs e)
        {
            try { LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadList() => dataGridViewData.DataSource = _stayRepository.ReadStays();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormStay>().ShowDialog(); LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}