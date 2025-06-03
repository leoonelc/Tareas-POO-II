namespace Gestion_De_Tareas_Pendientes
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.Button btnLimpiarLista;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTarea
            // 
            this.txtTarea.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTarea.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.txtTarea.Location = new System.Drawing.Point(12, 22);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(451, 37);
            this.txtTarea.TabIndex = 0;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.Teal;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarTarea.ForeColor = System.Drawing.Color.Ivory;
            this.btnAgregarTarea.Location = new System.Drawing.Point(111, 65);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(221, 46);
            this.btnAgregarTarea.TabIndex = 1;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // lstTareas
            // 
            this.lstTareas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.ItemHeight = 29;
            this.lstTareas.Location = new System.Drawing.Point(12, 117);
            this.lstTareas.Name = "lstTareas";
            this.lstTareas.Size = new System.Drawing.Size(451, 178);
            this.lstTareas.TabIndex = 2;
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarTarea.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarTarea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarTarea.Location = new System.Drawing.Point(12, 301);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(217, 43);
            this.btnEliminarTarea.TabIndex = 3;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiarLista.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarLista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiarLista.Location = new System.Drawing.Point(246, 301);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(217, 43);
            this.btnLimpiarLista.TabIndex = 4;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = false;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(475, 378);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.lstTareas);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnLimpiarLista);
            this.Name = "Form1";
            this.Text = "Gestión de Tareas Pendientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
