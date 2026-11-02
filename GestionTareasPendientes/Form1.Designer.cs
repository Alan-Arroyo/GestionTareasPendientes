namespace GestionTareasPendientes
{
    partial class Form1
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
            txtTarea = new TextBox();
            btnAgregarTarea = new Button();
            btnEliminarTarea = new Button();
            lstTareas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(41, 110);
            txtTarea.Multiline = true;
            txtTarea.Name = "txtTarea";
            txtTarea.PlaceholderText = "Nueva tarea...";
            txtTarea.Size = new Size(230, 23);
            txtTarea.TabIndex = 0;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.BackColor = Color.DodgerBlue;
            btnAgregarTarea.FlatAppearance.BorderSize = 0;
            btnAgregarTarea.FlatStyle = FlatStyle.Flat;
            btnAgregarTarea.ForeColor = Color.White;
            btnAgregarTarea.Location = new Point(111, 153);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(89, 23);
            btnAgregarTarea.TabIndex = 1;
            btnAgregarTarea.Text = "Agregar Tarea";
            btnAgregarTarea.UseVisualStyleBackColor = false;
            btnAgregarTarea.Click += this.btnAgregarTarea_Click;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.BackColor = Color.Salmon;
            btnEliminarTarea.FlatAppearance.BorderSize = 0;
            btnEliminarTarea.FlatStyle = FlatStyle.Flat;
            btnEliminarTarea.ForeColor = SystemColors.Control;
            btnEliminarTarea.Location = new Point(111, 268);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(89, 23);
            btnEliminarTarea.TabIndex = 2;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = false;
            btnEliminarTarea.Click += this.btnEliminarTarea_Click;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.Items.AddRange(new object[] { "" });
            lstTareas.Location = new Point(23, 191);
            lstTareas.MultiColumn = true;
            lstTareas.Name = "lstTareas";
            lstTareas.RightToLeft = RightToLeft.No;
            lstTareas.Size = new Size(260, 64);
            lstTareas.TabIndex = 3;
            lstTareas.SelectedIndexChanged += this.lstTareas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 4;
            label1.Text = "Gestor de Tareas Pendientes";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 69);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 5;
            label2.Text = "Ingrese una nueva tarea";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 330);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstTareas);
            Controls.Add(btnEliminarTarea);
            Controls.Add(btnAgregarTarea);
            Controls.Add(txtTarea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarea;
        private Button btnAgregarTarea;
        private Button btnEliminarTarea;
        private ListBox lstTareas;
        private Label label1;
        private Label label2;
    }
}
