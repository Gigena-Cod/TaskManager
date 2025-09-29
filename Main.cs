
namespace TaskManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        // Abrir vista de tareas
        private void verTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskList taskListForm = new TaskList();
            taskListForm.Show();
        }

        // Abrir vista para crear una nueva tarea
        private void crearTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTask addTaskForm = new CreateTask();
            addTaskForm.Show();
        }

        // Cerrar aplicación
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
