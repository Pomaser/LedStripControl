namespace LedStripeControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textValueRed = new System.Windows.Forms.TextBox();
            this.textValueGreen = new System.Windows.Forms.TextBox();
            this.textValueBlue = new System.Windows.Forms.TextBox();
            this.comboBoxPortNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxEffect = new System.Windows.Forms.ComboBox();
            this.effectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new LedStripeControl.Resources.AppData();
            this.effectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.colorHexagon = new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // setRToolStripMenuItem
            // 
            this.setRToolStripMenuItem.Name = "setRToolStripMenuItem";
            this.setRToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.setRToolStripMenuItem.Text = "Hide";
            this.setRToolStripMenuItem.Click += new System.EventHandler(this.setRToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(16, 27);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRed.Size = new System.Drawing.Size(45, 151);
            this.trackBarRed.TabIndex = 4;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(67, 27);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGreen.Size = new System.Drawing.Size(45, 151);
            this.trackBarGreen.TabIndex = 5;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarBlue_SCroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(118, 27);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBlue.Size = new System.Drawing.Size(45, 151);
            this.trackBarBlue.TabIndex = 6;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Port number:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(16, 52);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(85, 27);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Visible = false;
            this.buttonSend.Click += new System.EventHandler(this.sendButton_click);
            // 
            // textValueRed
            // 
            this.textValueRed.Location = new System.Drawing.Point(16, 185);
            this.textValueRed.Name = "textValueRed";
            this.textValueRed.ReadOnly = true;
            this.textValueRed.Size = new System.Drawing.Size(44, 20);
            this.textValueRed.TabIndex = 10;
            // 
            // textValueGreen
            // 
            this.textValueGreen.Location = new System.Drawing.Point(67, 185);
            this.textValueGreen.Name = "textValueGreen";
            this.textValueGreen.ReadOnly = true;
            this.textValueGreen.Size = new System.Drawing.Size(44, 20);
            this.textValueGreen.TabIndex = 11;
            // 
            // textValueBlue
            // 
            this.textValueBlue.Location = new System.Drawing.Point(118, 185);
            this.textValueBlue.Name = "textValueBlue";
            this.textValueBlue.ReadOnly = true;
            this.textValueBlue.Size = new System.Drawing.Size(44, 20);
            this.textValueBlue.TabIndex = 12;
            // 
            // comboBoxPortNo
            // 
            this.comboBoxPortNo.FormattingEnabled = true;
            this.comboBoxPortNo.Location = new System.Drawing.Point(16, 28);
            this.comboBoxPortNo.Name = "comboBoxPortNo";
            this.comboBoxPortNo.Size = new System.Drawing.Size(85, 21);
            this.comboBoxPortNo.TabIndex = 13;
            this.comboBoxPortNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPortSelection_SelectedIndexChanged);
            this.comboBoxPortNo.Click += new System.EventHandler(this.comboBoxPortSelection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "R";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "G";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "B";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxEffect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBarRed);
            this.panel1.Controls.Add(this.trackBarGreen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.trackBarBlue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textValueRed);
            this.panel1.Controls.Add(this.textValueGreen);
            this.panel1.Controls.Add(this.textValueBlue);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 251);
            this.panel1.TabIndex = 18;
            // 
            // comboBoxEffect
            // 
            this.comboBoxEffect.FormattingEnabled = true;
            this.comboBoxEffect.Items.AddRange(new object[] {
            "Default",
            "K.I.T.T",
            "Fader",
            "Rainbow"});
            this.comboBoxEffect.Location = new System.Drawing.Point(16, 212);
            this.comboBoxEffect.Name = "comboBoxEffect";
            this.comboBoxEffect.Size = new System.Drawing.Size(146, 21);
            this.comboBoxEffect.TabIndex = 17;
            this.comboBoxEffect.SelectedIndexChanged += new System.EventHandler(this.comboBoxEffect_SelectedIndexChanged);
            // 
            // effectsBindingSource1
            // 
            this.effectsBindingSource1.DataMember = "Effects";
            this.effectsBindingSource1.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // effectsBindingSource
            // 
            this.effectsBindingSource.DataMember = "Effects";
            this.effectsBindingSource.DataSource = this.appData;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonSend);
            this.panel2.Controls.Add(this.comboBoxPortNo);
            this.panel2.Location = new System.Drawing.Point(12, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 99);
            this.panel2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "© 2018 POMI Software";
            // 
            // colorHexagon
            // 
            this.colorHexagon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorHexagon.AutoSize = true;
            this.colorHexagon.Location = new System.Drawing.Point(191, 12);
            this.colorHexagon.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.colorHexagon.Name = "colorHexagon";
            this.colorHexagon.Size = new System.Drawing.Size(352, 379);
            this.colorHexagon.TabIndex = 17;
            this.colorHexagon.ColorChanged += new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon.ColorChangedEventHandler(this.colorHexagon_ColorChanged);
            this.colorHexagon.Load += new System.EventHandler(this.colorHexagon1_Load);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 403);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.colorHexagon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "LED Stripe Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textValueRed;
        private System.Windows.Forms.TextBox textValueGreen;
        private System.Windows.Forms.TextBox textValueBlue;
        private System.Windows.Forms.ComboBox comboBoxPortNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon colorHexagon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxEffect;
        private System.Windows.Forms.BindingSource effectsBindingSource;
        private Resources.AppData appData;
        private System.Windows.Forms.BindingSource effectsBindingSource1;
        private System.Windows.Forms.Label label5;
    }
}
