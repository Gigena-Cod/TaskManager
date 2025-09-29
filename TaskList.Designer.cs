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
            label4 = new Label();
            dateTimePicker3 = new DateTimePicker();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
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
            label2.Location = new Point(12, 313);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 3;
            label2.Text = "Desde:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(147, 313);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 5;
            label3.Text = "Hasta:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(147, 337);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(109, 23);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 379);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(529, 150);
            dataGridView1.TabIndex = 6;
            // 
            // label4
            // 
            label4.Location = new Point(6, 34);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 8;
            label4.Text = "Desde:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(6, 58);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(139, 23);
            dateTimePicker3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 23);
            textBox1.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(17, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 105);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear tarea";
            // 
            // label5
            // 
            label5.Location = new Point(161, 34);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 10;
            label5.Text = "Descripcion";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 337);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(109, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // TaskList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 531);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "TaskList";
            Text = "Registro y Gestión de Tareas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Label label4;
        private DateTimePicker dateTimePicker3;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
    }
}
