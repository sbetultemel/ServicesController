namespace Services_Controller
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.controltime = new DevExpress.XtraEditors.LabelControl();
            this.controlfunc = new DevExpress.XtraEditors.LabelControl();
            this.Missioncomp = new DevExpress.XtraEditors.SimpleButton();
            this.txttime = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.minute = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pid = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txttime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // controltime
            // 
            this.controltime.Appearance.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controltime.Appearance.Options.UseFont = true;
            this.controltime.Location = new System.Drawing.Point(62, 43);
            this.controltime.Name = "controltime";
            this.controltime.Size = new System.Drawing.Size(194, 19);
            this.controltime.TabIndex = 0;
            this.controltime.Text = "Kontrol edilecek süre:";
            // 
            // controlfunc
            // 
            this.controlfunc.Appearance.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlfunc.Appearance.Options.UseFont = true;
            this.controlfunc.Location = new System.Drawing.Point(62, 85);
            this.controlfunc.Name = "controlfunc";
            this.controlfunc.Size = new System.Drawing.Size(131, 19);
            this.controlfunc.TabIndex = 1;
            this.controlfunc.Text = "Kontrol islemi:";
            // 
            // Missioncomp
            // 
            this.Missioncomp.Appearance.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Missioncomp.Appearance.Options.UseFont = true;
            this.Missioncomp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Missioncomp.ImageOptions.Image")));
            this.Missioncomp.Location = new System.Drawing.Point(472, 235);
            this.Missioncomp.Name = "Missioncomp";
            this.Missioncomp.Size = new System.Drawing.Size(105, 41);
            this.Missioncomp.TabIndex = 3;
            this.Missioncomp.Text = "Görevi \r\ntamamla";
            this.Missioncomp.Click += new System.EventHandler(this.Missioncomp_Click);
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(286, 42);
            this.txttime.Name = "txttime";
            this.txttime.Properties.Appearance.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.Properties.Appearance.Options.UseFont = true;
            this.txttime.Size = new System.Drawing.Size(125, 24);
            this.txttime.TabIndex = 4;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(239, 82);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Başlat",
            "Durdur",
            "Kill"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(172, 24);
            this.comboBoxEdit1.TabIndex = 5;
            // 
            // minute
            // 
            this.minute.Appearance.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute.Appearance.Options.UseFont = true;
            this.minute.Location = new System.Drawing.Point(433, 43);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(27, 19);
            this.minute.TabIndex = 6;
            this.minute.Text = "dk.";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 158);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "PID:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(63, 158);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(147, 22);
            this.pid.TabIndex = 8;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(400, 158);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(177, 22);
            this.txtServiceName.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(269, 158);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 19);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Service Name:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(589, 288);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.Missioncomp);
            this.Controls.Add(this.controlfunc);
            this.Controls.Add(this.controltime);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Görev Zamanlayıcı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txttime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl controltime;
        private DevExpress.XtraEditors.LabelControl controlfunc;
        private DevExpress.XtraEditors.SimpleButton Missioncomp;
        private DevExpress.XtraEditors.TextEdit txttime;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl minute;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.TextBox txtServiceName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Timer timer1;
    }
}