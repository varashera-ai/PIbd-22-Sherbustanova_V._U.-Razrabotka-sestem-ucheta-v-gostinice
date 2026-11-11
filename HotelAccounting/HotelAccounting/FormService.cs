using System;
using System.Windows.Forms;
using HotelAccounting.Enums;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting
{
    public partial class FormService : Form
    {
        private readonly IServiceRepository _serviceRepository;
        private int? _serviceId;

        public int Id
        {
            set
            {
                try
                {
                    var service = _serviceRepository.ReadServiceById(value);
                    if (service == null) throw new InvalidOperationException("Услуга не найдена");

                    textBoxName.Text = service.Name;
                    numericUpDownPrice.Value = service.Price;

                    // Проходимся по всем значениям перечисления и ставим галочки, если флаг установлен
                    foreach (AdditionalServices elem in Enum.GetValues(typeof(AdditionalServices)))
                    {
                        if (elem != AdditionalServices.None && (elem & service.ServiceType) != 0)
                        {
                            checkedListBoxServiceType.SetItemChecked(checkedListBoxServiceType.Items.IndexOf(elem), true);
                        }
                    }
                    _serviceId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        public FormService(IServiceRepository serviceRepository)
        {
            InitializeComponent();
            _serviceRepository = serviceRepository ?? throw new ArgumentNullException(nameof(serviceRepository));

            // Заполняем CheckedListBox значениями из перечисления
            foreach (var elem in Enum.GetValues(typeof(AdditionalServices)))
            {
                if ((AdditionalServices)elem != AdditionalServices.None)
                {
                    checkedListBoxServiceType.Items.Add(elem);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) || checkedListBoxServiceType.CheckedItems.Count == 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                // Собираем флаги обратно из галочек
                AdditionalServices serviceType = AdditionalServices.None;
                foreach (var item in checkedListBoxServiceType.CheckedItems)
                {
                    serviceType |= (AdditionalServices)item;
                }

                if (_serviceId.HasValue)
                {
                    var service = Service.CreateEntity(_serviceId.Value, textBoxName.Text, numericUpDownPrice.Value, serviceType);
                    _serviceRepository.UpdateService(service);
                }
                else
                {
                    var service = Service.CreateEntity(0, textBoxName.Text, numericUpDownPrice.Value, serviceType);
                    _serviceRepository.CreateService(service);
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