namespace Win.Ventas
{
    partial class FormMenu
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
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoDeNiñosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoDeMujerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoDeHombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentoDeNiñosToolStripMenuItem,
            this.departamentoDeMujerToolStripMenuItem,
            this.departamentoDeHombreToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // departamentoDeNiñosToolStripMenuItem
            // 
            this.departamentoDeNiñosToolStripMenuItem.Name = "departamentoDeNiñosToolStripMenuItem";
            this.departamentoDeNiñosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.departamentoDeNiñosToolStripMenuItem.Text = "Departamento de Niños";
            this.departamentoDeNiñosToolStripMenuItem.Click += new System.EventHandler(this.departamentoDeNiñosToolStripMenuItem_Click);
            // 
            // departamentoDeMujerToolStripMenuItem
            // 
            this.departamentoDeMujerToolStripMenuItem.Name = "departamentoDeMujerToolStripMenuItem";
            this.departamentoDeMujerToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.departamentoDeMujerToolStripMenuItem.Text = "Departamento de Mujer";
            this.departamentoDeMujerToolStripMenuItem.Click += new System.EventHandler(this.departamentoDeMujerToolStripMenuItem_Click);
            // 
            // departamentoDeHombreToolStripMenuItem
            // 
            this.departamentoDeHombreToolStripMenuItem.Name = "departamentoDeHombreToolStripMenuItem";
            this.departamentoDeHombreToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.departamentoDeHombreToolStripMenuItem.Text = "Departamento de Hombre";
            this.departamentoDeHombreToolStripMenuItem.Click += new System.EventHandler(this.departamentoDeHombreToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 267);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoDeNiñosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoDeMujerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoDeHombreToolStripMenuItem;
    }
}