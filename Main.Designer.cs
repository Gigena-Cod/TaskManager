namespace TaskManager
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tareasToolStripMenuItem = new ToolStripMenuItem();
            verTareasToolStripMenuItem = new ToolStripMenuItem();
            crearTareaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, tareasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, salirToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // tareasToolStripMenuItem
            // 
            tareasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verTareasToolStripMenuItem, crearTareaToolStripMenuItem });
            tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            tareasToolStripMenuItem.Size = new Size(52, 20);
            tareasToolStripMenuItem.Text = "Tareas";
            // 
            // verTareasToolStripMenuItem
            // 
            verTareasToolStripMenuItem.Name = "verTareasToolStripMenuItem";
            verTareasToolStripMenuItem.Size = new Size(131, 22);
            verTareasToolStripMenuItem.Text = "Ver tareas";
            verTareasToolStripMenuItem.Click += verTareasToolStripMenuItem_Click;
            // 
            // crearTareaToolStripMenuItem
            // 
            crearTareaToolStripMenuItem.Name = "crearTareaToolStripMenuItem";
            crearTareaToolStripMenuItem.Size = new Size(131, 22);
            crearTareaToolStripMenuItem.Text = "Crear tarea";
            crearTareaToolStripMenuItem.Click += crearTareaToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro y Gestión de Tareas";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem tareasToolStripMenuItem;
        private ToolStripMenuItem verTareasToolStripMenuItem;
        private ToolStripMenuItem crearTareaToolStripMenuItem;
    }
}