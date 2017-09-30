namespace ProcessGestor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosCreadosPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosConMayorDuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosConMenorDuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cincoMenoresTiemposDeDuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igualDuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameProcess = new System.Windows.Forms.TextBox();
            this.txtTLlegada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesosCreadosPorUsuarioToolStripMenuItem,
            this.procesosConMayorDuracionToolStripMenuItem,
            this.procesosConMenorDuracionToolStripMenuItem,
            this.cincoMenoresTiemposDeDuracionToolStripMenuItem,
            this.ordenToolStripMenuItem,
            this.igualDuracionToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // procesosCreadosPorUsuarioToolStripMenuItem
            // 
            this.procesosCreadosPorUsuarioToolStripMenuItem.Name = "procesosCreadosPorUsuarioToolStripMenuItem";
            this.procesosCreadosPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.procesosCreadosPorUsuarioToolStripMenuItem.Text = "Procesos creados por usuario";
            this.procesosCreadosPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.procesosCreadosPorUsuarioToolStripMenuItem_Click);
            // 
            // procesosConMayorDuracionToolStripMenuItem
            // 
            this.procesosConMayorDuracionToolStripMenuItem.Name = "procesosConMayorDuracionToolStripMenuItem";
            this.procesosConMayorDuracionToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.procesosConMayorDuracionToolStripMenuItem.Text = "Procesos con mayor duracion";
            this.procesosConMayorDuracionToolStripMenuItem.Click += new System.EventHandler(this.procesosConMayorDuracionToolStripMenuItem_Click);
            // 
            // procesosConMenorDuracionToolStripMenuItem
            // 
            this.procesosConMenorDuracionToolStripMenuItem.Name = "procesosConMenorDuracionToolStripMenuItem";
            this.procesosConMenorDuracionToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.procesosConMenorDuracionToolStripMenuItem.Text = "Procesos con menor duracion";
            this.procesosConMenorDuracionToolStripMenuItem.Click += new System.EventHandler(this.procesosConMenorDuracionToolStripMenuItem_Click);
            // 
            // cincoMenoresTiemposDeDuracionToolStripMenuItem
            // 
            this.cincoMenoresTiemposDeDuracionToolStripMenuItem.Name = "cincoMenoresTiemposDeDuracionToolStripMenuItem";
            this.cincoMenoresTiemposDeDuracionToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.cincoMenoresTiemposDeDuracionToolStripMenuItem.Text = "Cinco menores tiempos de duracion";
            this.cincoMenoresTiemposDeDuracionToolStripMenuItem.Click += new System.EventHandler(this.cincoMenoresTiemposDeDuracionToolStripMenuItem_Click);
            // 
            // ordenToolStripMenuItem
            // 
            this.ordenToolStripMenuItem.Name = "ordenToolStripMenuItem";
            this.ordenToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.ordenToolStripMenuItem.Text = "Orden de terminacion de los procesos";
            this.ordenToolStripMenuItem.Click += new System.EventHandler(this.ordenToolStripMenuItem_Click);
            // 
            // igualDuracionToolStripMenuItem
            // 
            this.igualDuracionToolStripMenuItem.Name = "igualDuracionToolStripMenuItem";
            this.igualDuracionToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.igualDuracionToolStripMenuItem.Text = "Igual duracion";
            this.igualDuracionToolStripMenuItem.Click += new System.EventHandler(this.igualDuracionToolStripMenuItem_Click);
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(51, 50);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(211, 20);
            this.txtPID.TabIndex = 0;
            this.txtPID.Enter += new System.EventHandler(this.txtPID_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.Nombre,
            this.TiempoLlegada,
            this.Quantum,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(51, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(701, 121);
            this.dataGridView1.TabIndex = 3;
            // 
            // PID
            // 
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // TiempoLlegada
            // 
            this.TiempoLlegada.HeaderText = "Tiempo Llegada";
            this.TiempoLlegada.Name = "TiempoLlegada";
            this.TiempoLlegada.ReadOnly = true;
            // 
            // Quantum
            // 
            this.Quantum.HeaderText = "Quantum";
            this.Quantum.Name = "Quantum";
            this.Quantum.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Proceso";
            // 
            // txtNameProcess
            // 
            this.txtNameProcess.Location = new System.Drawing.Point(293, 50);
            this.txtNameProcess.Name = "txtNameProcess";
            this.txtNameProcess.Size = new System.Drawing.Size(211, 20);
            this.txtNameProcess.TabIndex = 1;
            // 
            // txtTLlegada
            // 
            this.txtTLlegada.Location = new System.Drawing.Point(541, 50);
            this.txtTLlegada.Name = "txtTLlegada";
            this.txtTLlegada.Size = new System.Drawing.Size(211, 20);
            this.txtTLlegada.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantum";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(701, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Añadir proceso";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(625, 241);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 44);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Iniciar procesos";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 291);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTLlegada);
            this.Controls.Add(this.txtNameProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameProcess;
        private System.Windows.Forms.TextBox txtTLlegada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosCreadosPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosConMayorDuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosConMenorDuracionToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripMenuItem cincoMenoresTiemposDeDuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igualDuracionToolStripMenuItem;
    }
}

