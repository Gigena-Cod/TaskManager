namespace TaskManager
{
    partial class TaskList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(529, 40);
            label1.TabIndex = 0;
            label1.Text = "Aplicación para registrar tareas con su descripción, fecha y estado. Permite visualizar todas las tareas en una grilla y filtrarlas por fecha o estado";
            // 
            // label2
            // 
            label2.Location = new Point(17, 75);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 3;
            label2.Text = "Desde:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(152, 75);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 5;
            label3.Text = "Hasta:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(152, 99);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(109, 23);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(529, 213);
            dataGridView1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(17, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(109, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(440, 94);
            button1.Name = "button1";
            button1.Size = new Size(106, 28);
            button1.TabIndex = 7;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.btnFilter_Click;
            // 
            // TaskList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 373);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "TaskList";
            Text = "Registro y Gestión de Tareas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}
