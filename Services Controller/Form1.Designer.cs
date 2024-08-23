namespace Services_Controller
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.queryService = new DevExpress.XtraEditors.SimpleButton();
            this.refreshList = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.heuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baslatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevZamanlayıcıAyarlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(83)))), ((int)(((byte)(41)))));
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.queryService);
            this.panelControl1.Controls.Add(this.refreshList);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1006, 71);
            this.panelControl1.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(147, 17);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEdit1.Size = new System.Drawing.Size(539, 26);
            this.textEdit1.TabIndex = 1;
            // 
            // queryService
            // 
            this.queryService.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.queryService.Appearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.queryService.Appearance.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryService.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.queryService.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.queryService.Appearance.Options.UseBackColor = true;
            this.queryService.Appearance.Options.UseBorderColor = true;
            this.queryService.Appearance.Options.UseFont = true;
            this.queryService.Appearance.Options.UseForeColor = true;
            this.queryService.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("queryService.ImageOptions.Image")));
            this.queryService.Location = new System.Drawing.Point(721, 15);
            this.queryService.Name = "queryService";
            this.queryService.Size = new System.Drawing.Size(129, 27);
            this.queryService.TabIndex = 0;
            this.queryService.Text = "Servisi Sorgula";
            this.queryService.Click += new System.EventHandler(this.queryService_Click);
            // 
            // refreshList
            // 
            this.refreshList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.refreshList.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.refreshList.Appearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.refreshList.Appearance.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshList.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.refreshList.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.refreshList.Appearance.Options.UseBackColor = true;
            this.refreshList.Appearance.Options.UseBorderColor = true;
            this.refreshList.Appearance.Options.UseFont = true;
            this.refreshList.Appearance.Options.UseForeColor = true;
            this.refreshList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshList.ImageOptions.Image")));
            this.refreshList.Location = new System.Drawing.Point(894, 14);
            this.refreshList.Name = "refreshList";
            this.refreshList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.refreshList.Size = new System.Drawing.Size(67, 29);
            this.refreshList.TabIndex = 0;
            this.refreshList.Text = "Yenile";
            this.refreshList.Click += new System.EventHandler(this.refreshList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 550);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heuToolStripMenuItem,
            this.baslatToolStripMenuItem,
            this.killToolStripMenuItem,
            this.görevZamanlayıcıAyarlaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 100);
            // 
            // heuToolStripMenuItem
            // 
            this.heuToolStripMenuItem.Name = "heuToolStripMenuItem";
            this.heuToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.heuToolStripMenuItem.Text = "Durdur";
            this.heuToolStripMenuItem.Click += new System.EventHandler(this.heuToolStripMenuItem_Click);
            // 
            // baslatToolStripMenuItem
            // 
            this.baslatToolStripMenuItem.Name = "baslatToolStripMenuItem";
            this.baslatToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.baslatToolStripMenuItem.Text = "Başlat";
            this.baslatToolStripMenuItem.Click += new System.EventHandler(this.baslatToolStripMenuItem_Click);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.killToolStripMenuItem.Text = "Kill";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // görevZamanlayıcıAyarlaToolStripMenuItem
            // 
            this.görevZamanlayıcıAyarlaToolStripMenuItem.Name = "görevZamanlayıcıAyarlaToolStripMenuItem";
            this.görevZamanlayıcıAyarlaToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.görevZamanlayıcıAyarlaToolStripMenuItem.Text = "Görev zamanlayıcı ayarla ";
            this.görevZamanlayıcıAyarlaToolStripMenuItem.Click += new System.EventHandler(this.görevZamanlayıcıAyarlaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Appearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(83)))), ((int)(((byte)(41)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "System Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton queryService;
        private DevExpress.XtraEditors.SimpleButton refreshList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baslatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevZamanlayıcıAyarlaToolStripMenuItem;
    }
}

