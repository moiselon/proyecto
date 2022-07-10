namespace desarrollo_web
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnatras = new System.Windows.Forms.ToolStripButton();
            this.btnadelante = new System.Windows.Forms.ToolStripButton();
            this.btnrefresh = new System.Windows.Forms.ToolStripButton();
            this.btnstop = new System.Windows.Forms.ToolStripButton();
            this.txturl = new System.Windows.Forms.ToolStripTextBox();
            this.btnsearch = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnatras,
            this.btnadelante,
            this.btnrefresh,
            this.btnstop,
            this.txturl,
            this.btnsearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnatras
            // 
            this.btnatras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnatras.Image = ((System.Drawing.Image)(resources.GetObject("btnatras.Image")));
            this.btnatras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(23, 22);
            this.btnatras.Text = "toolStripButton1";
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // btnadelante
            // 
            this.btnadelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnadelante.Image = ((System.Drawing.Image)(resources.GetObject("btnadelante.Image")));
            this.btnadelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnadelante.Name = "btnadelante";
            this.btnadelante.Size = new System.Drawing.Size(23, 22);
            this.btnadelante.Text = "toolStripButton1";
            this.btnadelante.Click += new System.EventHandler(this.btnadelante_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(23, 22);
            this.btnrefresh.Text = "toolStripButton1";
            this.btnrefresh.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnstop
            // 
            this.btnstop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnstop.Image = ((System.Drawing.Image)(resources.GetObject("btnstop.Image")));
            this.btnstop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(23, 22);
            this.btnstop.Text = "toolStripButton2";
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // txturl
            // 
            this.txturl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(600, 25);
            this.txturl.Text = " ";
            this.txturl.Click += new System.EventHandler(this.txturl_Click_1);
            // 
            // btnsearch
            // 
            this.btnsearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(23, 22);
            this.btnsearch.Text = "toolStripButton2";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 425);
            this.webBrowser1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "MOSSESCORP.";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnatras;
        private System.Windows.Forms.ToolStripButton btnadelante;
        private System.Windows.Forms.ToolStripButton btnrefresh;
        private System.Windows.Forms.ToolStripButton btnstop;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripTextBox txturl;
        private System.Windows.Forms.ToolStripButton btnsearch;
    }
}

