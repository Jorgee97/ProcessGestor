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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameProcess = new System.Windows.Forms.TextBox();
            this.txtTLlegada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.loadXML = new System.Windows.Forms.Button();
            this.ltReady = new System.Windows.Forms.ListBox();
            this.ltWait = new System.Windows.Forms.ListBox();
            this.ltRunning = new System.Windows.Forms.ListBox();
            this.ltEnd = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
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
            this.txtPID.Enabled = false;
            this.txtPID.Location = new System.Drawing.Point(51, 50);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(211, 20);
            this.txtPID.TabIndex = 0;
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
            this.txtNameProcess.Enter += new System.EventHandler(this.txtNameProcess_Enter);
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
            this.btnStart.Location = new System.Drawing.Point(22, 256);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(749, 35);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Iniciar procesos";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // loadXML
            // 
            this.loadXML.Location = new System.Drawing.Point(541, 0);
            this.loadXML.Name = "loadXML";
            this.loadXML.Size = new System.Drawing.Size(75, 23);
            this.loadXML.TabIndex = 9;
            this.loadXML.Text = "Cargar XML";
            this.loadXML.UseVisualStyleBackColor = true;
            this.loadXML.Click += new System.EventHandler(this.loadXML_Click);
            // 
            // ltReady
            // 
            this.ltReady.FormattingEnabled = true;
            this.ltReady.HorizontalScrollbar = true;
            this.ltReady.Location = new System.Drawing.Point(22, 144);
            this.ltReady.Name = "ltReady";
            this.ltReady.Size = new System.Drawing.Size(171, 95);
            this.ltReady.TabIndex = 10;
            // 
            // ltWait
            // 
            this.ltWait.FormattingEnabled = true;
            this.ltWait.HorizontalScrollbar = true;
            this.ltWait.Location = new System.Drawing.Point(210, 144);
            this.ltWait.Name = "ltWait";
            this.ltWait.Size = new System.Drawing.Size(171, 95);
            this.ltWait.TabIndex = 11;
            // 
            // ltRunning
            // 
            this.ltRunning.FormattingEnabled = true;
            this.ltRunning.HorizontalScrollbar = true;
            this.ltRunning.Location = new System.Drawing.Point(405, 144);
            this.ltRunning.Name = "ltRunning";
            this.ltRunning.Size = new System.Drawing.Size(170, 95);
            this.ltRunning.TabIndex = 12;
            // 
            // ltEnd
            // 
            this.ltEnd.FormattingEnabled = true;
            this.ltEnd.HorizontalScrollbar = true;
            this.ltEnd.Location = new System.Drawing.Point(596, 144);
            this.ltEnd.Name = "ltEnd";
            this.ltEnd.Size = new System.Drawing.Size(175, 95);
            this.ltEnd.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Listos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Espera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ejecutando";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Terminados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 312);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ltEnd);
            this.Controls.Add(this.ltRunning);
            this.Controls.Add(this.ltWait);
            this.Controls.Add(this.ltReady);
            this.Controls.Add(this.loadXML);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTLlegada);
            this.Controls.Add(this.txtNameProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button loadXML;
        private System.Windows.Forms.ListBox ltReady;
        private System.Windows.Forms.ListBox ltWait;
        private System.Windows.Forms.ListBox ltRunning;
        private System.Windows.Forms.ListBox ltEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

