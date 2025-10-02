
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TaskManager.Domain.Services;
using Task = TaskManager.Domain.Models.Task;

namespace TaskManager
{
    public partial class CreateTask : Form
    {

        private readonly TaskService _taskService;

        public CreateTask() 
        {
            InitializeComponent();

            _taskService = new TaskService();

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



        private void CreateTask_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string description = textBoxDescription.Text.Trim();
            DateTime date = dateTimePickerDate.Value;
            string status = "In Progress";

            // Validaciones
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (date < DateTime.Today)
            {
                MessageBox.Show("La fecha no puede ser anterior a hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear tarea y agregarla a la lista
            var task = new Task(description, date, status);
            
            _taskService.Create(task);

            // Limpiar campos
            textBoxDescription.Clear();
            dateTimePickerDate.Value = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // cancelar
        }
    }
}
