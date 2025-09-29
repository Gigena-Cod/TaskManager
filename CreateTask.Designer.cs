namespace TaskManager
{
    partial class CreateTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label5 = new Label();
            dateTimePicker3 = new DateTimePicker();
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(21, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 179);
            groupBox1.TabIndex = 12;
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
            // label4
            // 
            label4.Location = new Point(6, 34);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 8;
            label4.Text = "Desde:";
            // 
            // label1
            // 
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(529, 40);
            label1.TabIndex = 11;
            label1.Text = "Aplicación para registrar tareas con su descripción, fecha y estado. Permite visualizar todas las tareas en una grilla y filtrarlas por fecha o estado";
            // 
            // ViewTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 351);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ViewTasks";
            Text = "ViewTasks";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private DateTimePicker dateTimePicker3;
        private TextBox textBox1;
        private Label label4;
        private Label label1;
    }
}