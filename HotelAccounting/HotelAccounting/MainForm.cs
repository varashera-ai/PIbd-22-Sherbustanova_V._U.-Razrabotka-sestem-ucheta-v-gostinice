using System;
using System.Windows.Forms;
using Unity;

namespace HotelAccounting
{
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;

        public MainForm(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void категорииНомеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormRoomCategories>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при открытии", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void номераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormRooms>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при открытии", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void гостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormGuests>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при открытии", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormServices>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при открытии", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void бронированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormBookings>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при открытии", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void заселенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormStays>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при открытии", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отчеты будут добавлены в лабораторной работе №3", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}