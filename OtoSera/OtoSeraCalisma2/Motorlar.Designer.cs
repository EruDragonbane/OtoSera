namespace OtoSeraCalisma2
{
    partial class makineler_form
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
            this.motorBaglan_butonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ports_combobox = new System.Windows.Forms.ComboBox();
            this.servomotor_groupbox = new System.Windows.Forms.GroupBox();
            this.MotorPort = new System.IO.Ports.SerialPort(this.components);
            this.dcmotorhiz_groupbox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.motorhiz_ibresi = new System.Windows.Forms.Label();
            this.hiz_trackbar = new System.Windows.Forms.TrackBar();
            this.port_label = new System.Windows.Forms.Label();
            this.sagyon_butonu = new System.Windows.Forms.RadioButton();
            this.solyon_butonu = new System.Windows.Forms.RadioButton();
            this.dcmotoryon_groupbox = new System.Windows.Forms.GroupBox();
            this.servo_ac_butonu = new System.Windows.Forms.Button();
            this.servo_kapat_butonu = new System.Windows.Forms.Button();
            this.servomotor_groupbox.SuspendLayout();
            this.dcmotorhiz_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiz_trackbar)).BeginInit();
            this.dcmotoryon_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // motorBaglan_butonu
            // 
            this.motorBaglan_butonu.Location = new System.Drawing.Point(311, 39);
            this.motorBaglan_butonu.Name = "motorBaglan_butonu";
            this.motorBaglan_butonu.Size = new System.Drawing.Size(75, 23);
            this.motorBaglan_butonu.TabIndex = 0;
            this.motorBaglan_butonu.Text = "Bağlan";
            this.motorBaglan_butonu.UseVisualStyleBackColor = true;
            this.motorBaglan_butonu.Click += new System.EventHandler(this.motorBaglan_butonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bağlanılacak Port:";
            // 
            // ports_combobox
            // 
            this.ports_combobox.FormattingEnabled = true;
            this.ports_combobox.Location = new System.Drawing.Point(105, 12);
            this.ports_combobox.Name = "ports_combobox";
            this.ports_combobox.Size = new System.Drawing.Size(281, 21);
            this.ports_combobox.TabIndex = 2;
            // 
            // servomotor_groupbox
            // 
            this.servomotor_groupbox.Controls.Add(this.servo_kapat_butonu);
            this.servomotor_groupbox.Controls.Add(this.servo_ac_butonu);
            this.servomotor_groupbox.Location = new System.Drawing.Point(197, 68);
            this.servomotor_groupbox.Name = "servomotor_groupbox";
            this.servomotor_groupbox.Size = new System.Drawing.Size(189, 56);
            this.servomotor_groupbox.TabIndex = 4;
            this.servomotor_groupbox.TabStop = false;
            this.servomotor_groupbox.Text = "Su Deposu Makinesi";
            // 
            // dcmotorhiz_groupbox
            // 
            this.dcmotorhiz_groupbox.Controls.Add(this.label3);
            this.dcmotorhiz_groupbox.Controls.Add(this.label2);
            this.dcmotorhiz_groupbox.Controls.Add(this.motorhiz_ibresi);
            this.dcmotorhiz_groupbox.Controls.Add(this.hiz_trackbar);
            this.dcmotorhiz_groupbox.Location = new System.Drawing.Point(9, 130);
            this.dcmotorhiz_groupbox.Name = "dcmotorhiz_groupbox";
            this.dcmotorhiz_groupbox.Size = new System.Drawing.Size(377, 86);
            this.dcmotorhiz_groupbox.TabIndex = 6;
            this.dcmotorhiz_groupbox.TabStop = false;
            this.dcmotorhiz_groupbox.Text = "Çapalama Hızı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "%100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "%0";
            // 
            // motorhiz_ibresi
            // 
            this.motorhiz_ibresi.AutoSize = true;
            this.motorhiz_ibresi.Location = new System.Drawing.Point(182, 67);
            this.motorhiz_ibresi.Name = "motorhiz_ibresi";
            this.motorhiz_ibresi.Size = new System.Drawing.Size(0, 13);
            this.motorhiz_ibresi.TabIndex = 1;
            // 
            // hiz_trackbar
            // 
            this.hiz_trackbar.Location = new System.Drawing.Point(3, 19);
            this.hiz_trackbar.Name = "hiz_trackbar";
            this.hiz_trackbar.Size = new System.Drawing.Size(368, 45);
            this.hiz_trackbar.TabIndex = 0;
            this.hiz_trackbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.hiz_trackbar.Scroll += new System.EventHandler(this.hiz_trackbar_Scroll);
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(102, 44);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(0, 13);
            this.port_label.TabIndex = 7;
            // 
            // sagyon_butonu
            // 
            this.sagyon_butonu.AutoSize = true;
            this.sagyon_butonu.Location = new System.Drawing.Point(9, 33);
            this.sagyon_butonu.Name = "sagyon_butonu";
            this.sagyon_butonu.Size = new System.Drawing.Size(47, 17);
            this.sagyon_butonu.TabIndex = 1;
            this.sagyon_butonu.TabStop = true;
            this.sagyon_butonu.Text = "SAĞ";
            this.sagyon_butonu.UseVisualStyleBackColor = true;
            this.sagyon_butonu.CheckedChanged += new System.EventHandler(this.sagyon_butonu_CheckedChanged);
            // 
            // solyon_butonu
            // 
            this.solyon_butonu.AutoSize = true;
            this.solyon_butonu.Location = new System.Drawing.Point(62, 32);
            this.solyon_butonu.Name = "solyon_butonu";
            this.solyon_butonu.Size = new System.Drawing.Size(46, 17);
            this.solyon_butonu.TabIndex = 2;
            this.solyon_butonu.TabStop = true;
            this.solyon_butonu.Text = "SOL";
            this.solyon_butonu.UseVisualStyleBackColor = true;
            this.solyon_butonu.CheckedChanged += new System.EventHandler(this.solyon_butonu_CheckedChanged);
            // 
            // dcmotoryon_groupbox
            // 
            this.dcmotoryon_groupbox.Controls.Add(this.solyon_butonu);
            this.dcmotoryon_groupbox.Controls.Add(this.sagyon_butonu);
            this.dcmotoryon_groupbox.Location = new System.Drawing.Point(3, 68);
            this.dcmotoryon_groupbox.Name = "dcmotoryon_groupbox";
            this.dcmotoryon_groupbox.Size = new System.Drawing.Size(188, 56);
            this.dcmotoryon_groupbox.TabIndex = 3;
            this.dcmotoryon_groupbox.TabStop = false;
            this.dcmotoryon_groupbox.Text = "Çapalama Yönü";
            // 
            // servo_ac_butonu
            // 
            this.servo_ac_butonu.Location = new System.Drawing.Point(6, 26);
            this.servo_ac_butonu.Name = "servo_ac_butonu";
            this.servo_ac_butonu.Size = new System.Drawing.Size(75, 23);
            this.servo_ac_butonu.TabIndex = 0;
            this.servo_ac_butonu.Text = "AÇ";
            this.servo_ac_butonu.UseVisualStyleBackColor = true;
            this.servo_ac_butonu.Click += new System.EventHandler(this.servo_ac_butonu_Click);
            // 
            // servo_kapat_butonu
            // 
            this.servo_kapat_butonu.Location = new System.Drawing.Point(108, 26);
            this.servo_kapat_butonu.Name = "servo_kapat_butonu";
            this.servo_kapat_butonu.Size = new System.Drawing.Size(75, 23);
            this.servo_kapat_butonu.TabIndex = 1;
            this.servo_kapat_butonu.Text = "KAPAT";
            this.servo_kapat_butonu.UseVisualStyleBackColor = true;
            this.servo_kapat_butonu.Click += new System.EventHandler(this.servo_kapat_butonu_Click);
            // 
            // makineler_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 228);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.dcmotorhiz_groupbox);
            this.Controls.Add(this.servomotor_groupbox);
            this.Controls.Add(this.dcmotoryon_groupbox);
            this.Controls.Add(this.ports_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.motorBaglan_butonu);
            this.Name = "makineler_form";
            this.Text = "Makineler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.makineler_form_FormClosing);
            this.Load += new System.EventHandler(this.makineler_form_Load);
            this.servomotor_groupbox.ResumeLayout(false);
            this.dcmotorhiz_groupbox.ResumeLayout(false);
            this.dcmotorhiz_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiz_trackbar)).EndInit();
            this.dcmotoryon_groupbox.ResumeLayout(false);
            this.dcmotoryon_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button motorBaglan_butonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ports_combobox;
        private System.Windows.Forms.GroupBox servomotor_groupbox;
        private System.IO.Ports.SerialPort MotorPort;
        private System.Windows.Forms.GroupBox dcmotorhiz_groupbox;
        private System.Windows.Forms.TrackBar hiz_trackbar;
        private System.Windows.Forms.Label motorhiz_ibresi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.RadioButton sagyon_butonu;
        private System.Windows.Forms.RadioButton solyon_butonu;
        private System.Windows.Forms.GroupBox dcmotoryon_groupbox;
        private System.Windows.Forms.Button servo_kapat_butonu;
        private System.Windows.Forms.Button servo_ac_butonu;
    }
}