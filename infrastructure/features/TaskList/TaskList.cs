using System.Windows.Forms.VisualStyles;
using TaskManager.Domain.Services;

namespace TaskManager
{
    public partial class TaskList : Form
    {
        private readonly TaskService _taskService;
 
        public TaskList()
        {
            InitializeComponent();

            _taskService = new TaskService();

            // Configuramos DataGridView para auto generar columnas
            dataGridView1.AutoGenerateColumns = true;

            // Cargar datos iniciales
            LoadTasks();

            // Evitar que se redimensione
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Evitar que se mueva (deshabilita el arrastre desde la barra de título)
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Sobrescribir WndProc para bloquear movimiento
        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && (int)m.WParam == HTCAPTION)
            {
                return; // Bloquea arrastre
            }
            base.WndProc(ref m);
        }


        private void LoadTasks()
        {
            DateTime? from = dateTimePicker1.Value;
            DateTime? to = dateTimePicker2.Value;

            var filteredTasks = _taskService.GetFiltered(from, to);

            // Enlazar al DataGridView
            dataGridView1.DataSource = null; // limpiar primero
            dataGridView1.DataSource = filteredTasks;
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime? from = dateTimePicker1.Value;
            DateTime? to = dateTimePicker2.Value; 

            var filteredTasks = _taskService.GetFiltered(from, to);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredTasks;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
