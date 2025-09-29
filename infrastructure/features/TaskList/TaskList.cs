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
            // Obtener todas las tareas
            var tasks = _taskService.GetAll();

            // Enlazar al DataGridView
            dataGridView1.DataSource = null; // limpiar primero
            dataGridView1.DataSource = tasks;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
