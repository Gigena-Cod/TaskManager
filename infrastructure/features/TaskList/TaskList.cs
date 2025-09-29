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
