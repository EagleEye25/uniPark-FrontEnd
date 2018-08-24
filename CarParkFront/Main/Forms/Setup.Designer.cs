namespace CarParkFront.Main.Forms
{
    partial class frmSetup
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
            this.pnlMainGate = new System.Windows.Forms.Panel();
            this.rdoEntrance = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoExit = new MaterialSkin.Controls.MaterialRadioButton();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoDisableScan = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoEnableScan = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoDisableCam = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoEnableCam = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblDesc = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.rdoGate = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoArea = new MaterialSkin.Controls.MaterialRadioButton();
            this.matbtnContinue = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlMainGate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainGate
            // 
            this.pnlMainGate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.pnlMainGate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainGate.Controls.Add(this.rdoEntrance);
            this.pnlMainGate.Controls.Add(this.rdoExit);
            this.pnlMainGate.Controls.Add(this.cbxName);
            this.pnlMainGate.Controls.Add(this.materialLabel3);
            this.pnlMainGate.Controls.Add(this.materialLabel2);
            this.pnlMainGate.Controls.Add(this.panel3);
            this.pnlMainGate.Controls.Add(this.panel2);
            this.pnlMainGate.Location = new System.Drawing.Point(232, 120);
            this.pnlMainGate.Name = "pnlMainGate";
            this.pnlMainGate.Size = new System.Drawing.Size(394, 391);
            this.pnlMainGate.TabIndex = 0;
            this.pnlMainGate.Visible = false;
            // 
            // rdoEntrance
            // 
            this.rdoEntrance.AutoSize = true;
            this.rdoEntrance.Depth = 0;
            this.rdoEntrance.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoEntrance.Location = new System.Drawing.Point(131, 59);
            this.rdoEntrance.Margin = new System.Windows.Forms.Padding(0);
            this.rdoEntrance.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoEntrance.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoEntrance.Name = "rdoEntrance";
            this.rdoEntrance.Ripple = true;
            this.rdoEntrance.Size = new System.Drawing.Size(83, 30);
            this.rdoEntrance.TabIndex = 6;
            this.rdoEntrance.TabStop = true;
            this.rdoEntrance.Text = "Entrance";
            this.rdoEntrance.UseVisualStyleBackColor = true;
            // 
            // rdoExit
            // 
            this.rdoExit.AutoSize = true;
            this.rdoExit.Depth = 0;
            this.rdoExit.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoExit.Location = new System.Drawing.Point(14, 59);
            this.rdoExit.Margin = new System.Windows.Forms.Padding(0);
            this.rdoExit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoExit.Name = "rdoExit";
            this.rdoExit.Ripple = true;
            this.rdoExit.Size = new System.Drawing.Size(52, 30);
            this.rdoExit.TabIndex = 5;
            this.rdoExit.TabStop = true;
            this.rdoExit.Text = "Exit";
            this.rdoExit.UseVisualStyleBackColor = true;
            // 
            // cbxName
            // 
            this.cbxName.BackColor = System.Drawing.SystemColors.Window;
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(14, 29);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(200, 21);
            this.cbxName.TabIndex = 4;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(10, 108);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Scanners";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 254);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Cam";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rdoDisableScan);
            this.panel3.Controls.Add(this.rdoEnableScan);
            this.panel3.Location = new System.Drawing.Point(14, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 100);
            this.panel3.TabIndex = 1;
            // 
            // rdoDisableScan
            // 
            this.rdoDisableScan.AutoSize = true;
            this.rdoDisableScan.Depth = 0;
            this.rdoDisableScan.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoDisableScan.Location = new System.Drawing.Point(14, 52);
            this.rdoDisableScan.Margin = new System.Windows.Forms.Padding(0);
            this.rdoDisableScan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoDisableScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoDisableScan.Name = "rdoDisableScan";
            this.rdoDisableScan.Ripple = true;
            this.rdoDisableScan.Size = new System.Drawing.Size(128, 30);
            this.rdoDisableScan.TabIndex = 1;
            this.rdoDisableScan.TabStop = true;
            this.rdoDisableScan.Text = "Disable Scanner";
            this.rdoDisableScan.UseVisualStyleBackColor = true;
            this.rdoDisableScan.CheckedChanged += new System.EventHandler(this.rdoDisableScan_CheckedChanged);
            // 
            // rdoEnableScan
            // 
            this.rdoEnableScan.AutoSize = true;
            this.rdoEnableScan.Depth = 0;
            this.rdoEnableScan.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoEnableScan.Location = new System.Drawing.Point(14, 22);
            this.rdoEnableScan.Margin = new System.Windows.Forms.Padding(0);
            this.rdoEnableScan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoEnableScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoEnableScan.Name = "rdoEnableScan";
            this.rdoEnableScan.Ripple = true;
            this.rdoEnableScan.Size = new System.Drawing.Size(124, 30);
            this.rdoEnableScan.TabIndex = 0;
            this.rdoEnableScan.TabStop = true;
            this.rdoEnableScan.Text = "Enable Scanner";
            this.rdoEnableScan.UseVisualStyleBackColor = true;
            this.rdoEnableScan.CheckedChanged += new System.EventHandler(this.rdoEnableScan_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdoDisableCam);
            this.panel2.Controls.Add(this.rdoEnableCam);
            this.panel2.Location = new System.Drawing.Point(14, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 100);
            this.panel2.TabIndex = 0;
            // 
            // rdoDisableCam
            // 
            this.rdoDisableCam.AutoSize = true;
            this.rdoDisableCam.Depth = 0;
            this.rdoDisableCam.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoDisableCam.Location = new System.Drawing.Point(14, 51);
            this.rdoDisableCam.Margin = new System.Windows.Forms.Padding(0);
            this.rdoDisableCam.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoDisableCam.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoDisableCam.Name = "rdoDisableCam";
            this.rdoDisableCam.Ripple = true;
            this.rdoDisableCam.Size = new System.Drawing.Size(106, 30);
            this.rdoDisableCam.TabIndex = 1;
            this.rdoDisableCam.TabStop = true;
            this.rdoDisableCam.Text = "Disable Cam";
            this.rdoDisableCam.UseVisualStyleBackColor = true;
            // 
            // rdoEnableCam
            // 
            this.rdoEnableCam.AutoSize = true;
            this.rdoEnableCam.Depth = 0;
            this.rdoEnableCam.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoEnableCam.Location = new System.Drawing.Point(14, 21);
            this.rdoEnableCam.Margin = new System.Windows.Forms.Padding(0);
            this.rdoEnableCam.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoEnableCam.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoEnableCam.Name = "rdoEnableCam";
            this.rdoEnableCam.Ripple = true;
            this.rdoEnableCam.Size = new System.Drawing.Size(102, 30);
            this.rdoEnableCam.TabIndex = 0;
            this.rdoEnableCam.TabStop = true;
            this.rdoEnableCam.Text = "Enable Cam";
            this.rdoEnableCam.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Depth = 0;
            this.lblDesc.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDesc.Location = new System.Drawing.Point(228, 98);
            this.lblDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(42, 19);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Main";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(24, 98);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(176, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Main Gate / Parking Area";
            // 
            // rdoGate
            // 
            this.rdoGate.AutoSize = true;
            this.rdoGate.Depth = 0;
            this.rdoGate.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoGate.Location = new System.Drawing.Point(28, 150);
            this.rdoGate.Margin = new System.Windows.Forms.Padding(0);
            this.rdoGate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoGate.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoGate.Name = "rdoGate";
            this.rdoGate.Ripple = true;
            this.rdoGate.Size = new System.Drawing.Size(92, 30);
            this.rdoGate.TabIndex = 3;
            this.rdoGate.TabStop = true;
            this.rdoGate.Text = "Main Gate";
            this.rdoGate.UseVisualStyleBackColor = true;
            this.rdoGate.CheckedChanged += new System.EventHandler(this.materialRadioButton5_CheckedChanged);
            // 
            // rdoArea
            // 
            this.rdoArea.AutoSize = true;
            this.rdoArea.Depth = 0;
            this.rdoArea.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoArea.Location = new System.Drawing.Point(28, 180);
            this.rdoArea.Margin = new System.Windows.Forms.Padding(0);
            this.rdoArea.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoArea.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoArea.Name = "rdoArea";
            this.rdoArea.Ripple = true;
            this.rdoArea.Size = new System.Drawing.Size(108, 30);
            this.rdoArea.TabIndex = 4;
            this.rdoArea.TabStop = true;
            this.rdoArea.Text = "Parking Area";
            this.rdoArea.UseVisualStyleBackColor = true;
            this.rdoArea.CheckedChanged += new System.EventHandler(this.materialRadioButton6_CheckedChanged);
            // 
            // matbtnContinue
            // 
            this.matbtnContinue.AutoSize = true;
            this.matbtnContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnContinue.Depth = 0;
            this.matbtnContinue.Icon = null;
            this.matbtnContinue.Location = new System.Drawing.Point(28, 475);
            this.matbtnContinue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnContinue.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnContinue.Name = "matbtnContinue";
            this.matbtnContinue.Primary = false;
            this.matbtnContinue.Size = new System.Drawing.Size(88, 36);
            this.matbtnContinue.TabIndex = 6;
            this.matbtnContinue.Text = "Continue";
            this.matbtnContinue.UseVisualStyleBackColor = true;
            this.matbtnContinue.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(647, 532);
            this.Controls.Add(this.matbtnContinue);
            this.Controls.Add(this.rdoArea);
            this.Controls.Add(this.rdoGate);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.pnlMainGate);
            this.Name = "frmSetup";
            this.Text = "Setup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSetup_FormClosed);
            this.Load += new System.EventHandler(this.frmSetup_Load);
            this.pnlMainGate.ResumeLayout(false);
            this.pnlMainGate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainGate;
        private MaterialSkin.Controls.MaterialLabel lblDesc;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialRadioButton rdoDisableScan;
        private MaterialSkin.Controls.MaterialRadioButton rdoEnableScan;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRadioButton rdoDisableCam;
        private MaterialSkin.Controls.MaterialRadioButton rdoEnableCam;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRadioButton rdoGate;
        private MaterialSkin.Controls.MaterialRadioButton rdoArea;
        private System.Windows.Forms.ComboBox cbxName;
        private MaterialSkin.Controls.MaterialFlatButton matbtnContinue;
        private MaterialSkin.Controls.MaterialRadioButton rdoEntrance;
        private MaterialSkin.Controls.MaterialRadioButton rdoExit;
    }
}