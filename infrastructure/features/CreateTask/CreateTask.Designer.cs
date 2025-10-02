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
            label1 = new Label();
            label4 = new Label();
            textBoxDescription = new TextBox();
            dateTimePickerDate = new DateTimePicker();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(529, 40);
            label1.TabIndex = 11;
            label1.Text = "Aplicación para registrar tareas con su descripción, fecha y estado. Permite visualizar todas las tareas en una grilla y filtrarlas por fecha o estado";
            // 
            // label4
            // 
            label4.Location = new Point(21, 75);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 8;
            label4.Text = "Desde:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(176, 99);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(374, 23);
            textBoxDescription.TabIndex = 9;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(21, 99);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(139, 23);
            dateTimePickerDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.Location = new Point(176, 75);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 10;
            label5.Text = "Descripcion";
            // 
            // button1
            // 
            button1.Location = new Point(293, 155);
            button1.Name = "button1";
            button1.Size = new Size(112, 32);
            button1.TabIndex = 12;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(157, 155);
            button2.Name = "button2";
            button2.Size = new Size(112, 32);
            button2.TabIndex = 13;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CreateTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 199);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(dateTimePickerDate);
            Controls.Add(label1);
            Controls.Add(textBoxDescription);
            Controls.Add(label4);
            Name = "CreateTask";
            Text = "Crear tarea";
            Load += CreateTask_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label4;
        private TextBox textBoxDescription;
        private DateTimePicker dateTimePickerDate;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}