namespace CarParkFront.Main.Forms
{
    partial class frmEntrance
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
            this.mattxtUserID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.matbtnSettings = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlCam = new System.Windows.Forms.Panel();
            this.pnlManual = new System.Windows.Forms.Panel();
            this.matbtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.matbtnAccept = new MaterialSkin.Controls.MaterialFlatButton();
            this.mattxtPlate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.matbtnSource = new MaterialSkin.Controls.MaterialFlatButton();
            this.ChangeSetupTip = new System.Windows.Forms.ToolTip(this.components);
            this.VideoSourceTip = new System.Windows.Forms.ToolTip(this.components);
            this.matbtnClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.matlblError = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.ClearTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCam.SuspendLayout();
            this.pnlManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // mattxtUserID
            // 
            this.mattxtUserID.Depth = 0;
            this.mattxtUserID.Hint = "";
            this.mattxtUserID.Location = new System.Drawing.Point(23, 109);
            this.mattxtUserID.MaxLength = 32767;
            this.mattxtUserID.MouseState = MaterialSkin.MouseState.HOVER;
            this.mattxtUserID.Name = "mattxtUserID";
            this.mattxtUserID.PasswordChar = '\0';
            this.mattxtUserID.SelectedText = "";
            this.mattxtUserID.SelectionLength = 0;
            this.mattxtUserID.SelectionStart = 0;
            this.mattxtUserID.Size = new System.Drawing.Size(176, 23);
            this.mattxtUserID.TabIndex = 0;
            this.mattxtUserID.TabStop = false;
            this.mattxtUserID.Text = "User ID";
            this.mattxtUserID.UseSystemPasswordChar = false;
            this.mattxtUserID.Click += new System.EventHandler(this.mattxtUserID_Click);
            this.mattxtUserID.Enter += new System.EventHandler(this.mattxtUserID_Enter);
            this.mattxtUserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mattxtUserID_KeyDown);
            this.mattxtUserID.Leave += new System.EventHandler(this.mattxtUserID_Leave);
            this.mattxtUserID.TextChanged += new System.EventHandler(this.mattxtUserID_TextChanged);
            // 
            // matbtnSettings
            // 
            this.matbtnSettings.AutoSize = true;
            this.matbtnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnSettings.BackColor = System.Drawing.SystemColors.Control;
            this.matbtnSettings.Depth = 0;
            this.matbtnSettings.Icon = null;
            this.matbtnSettings.Location = new System.Drawing.Point(366, 96);
            this.matbtnSettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnSettings.Name = "matbtnSettings";
            this.matbtnSettings.Primary = false;
            this.matbtnSettings.Size = new System.Drawing.Size(121, 36);
            this.matbtnSettings.TabIndex = 1;
            this.matbtnSettings.Text = "Change setup";
            this.ChangeSetupTip.SetToolTip(this.matbtnSettings, "This button will take you back to the steup page");
            this.matbtnSettings.UseVisualStyleBackColor = false;
            this.matbtnSettings.Click += new System.EventHandler(this.matbtnSettings_Click);
            // 
            // pnlCam
            // 
            this.pnlCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.pnlCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCam.Controls.Add(this.pnlManual);
            this.pnlCam.Controls.Add(this.imgCapture);
            this.pnlCam.Controls.Add(this.imgVideo);
            this.pnlCam.Location = new System.Drawing.Point(23, 138);
            this.pnlCam.Name = "pnlCam";
            this.pnlCam.Size = new System.Drawing.Size(467, 214);
            this.pnlCam.TabIndex = 2;
            // 
            // pnlManual
            // 
            this.pnlManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlManual.Controls.Add(this.matbtnCancel);
            this.pnlManual.Controls.Add(this.matbtnAccept);
            this.pnlManual.Controls.Add(this.mattxtPlate);
            this.pnlManual.Location = new System.Drawing.Point(70, 41);
            this.pnlManual.Name = "pnlManual";
            this.pnlManual.Size = new System.Drawing.Size(312, 128);
            this.pnlManual.TabIndex = 4;
            // 
            // matbtnCancel
            // 
            this.matbtnCancel.AutoSize = true;
            this.matbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnCancel.Depth = 0;
            this.matbtnCancel.Icon = null;
            this.matbtnCancel.Location = new System.Drawing.Point(189, 75);
            this.matbtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnCancel.Name = "matbtnCancel";
            this.matbtnCancel.Primary = false;
            this.matbtnCancel.Size = new System.Drawing.Size(73, 36);
            this.matbtnCancel.TabIndex = 2;
            this.matbtnCancel.Text = "Cancel";
            this.matbtnCancel.UseVisualStyleBackColor = true;
            this.matbtnCancel.Click += new System.EventHandler(this.matbtnCancel_Click_1);
            // 
            // matbtnAccept
            // 
            this.matbtnAccept.AutoSize = true;
            this.matbtnAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnAccept.Depth = 0;
            this.matbtnAccept.Icon = null;
            this.matbtnAccept.Location = new System.Drawing.Point(54, 75);
            this.matbtnAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnAccept.Name = "matbtnAccept";
            this.matbtnAccept.Primary = false;
            this.matbtnAccept.Size = new System.Drawing.Size(73, 36);
            this.matbtnAccept.TabIndex = 1;
            this.matbtnAccept.Text = "Accept";
            this.matbtnAccept.UseVisualStyleBackColor = true;
            this.matbtnAccept.Click += new System.EventHandler(this.matbtnAccept_Click);
            // 
            // mattxtPlate
            // 
            this.mattxtPlate.Depth = 0;
            this.mattxtPlate.Hint = "";
            this.mattxtPlate.Location = new System.Drawing.Point(54, 39);
            this.mattxtPlate.MaxLength = 32767;
            this.mattxtPlate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mattxtPlate.Name = "mattxtPlate";
            this.mattxtPlate.PasswordChar = '\0';
            this.mattxtPlate.SelectedText = "";
            this.mattxtPlate.SelectionLength = 0;
            this.mattxtPlate.SelectionStart = 0;
            this.mattxtPlate.Size = new System.Drawing.Size(208, 23);
            this.mattxtPlate.TabIndex = 0;
            this.mattxtPlate.TabStop = false;
            this.mattxtPlate.Text = "Enter plate number";
            this.mattxtPlate.UseSystemPasswordChar = false;
            // 
            // imgCapture
            // 
            this.imgCapture.Location = new System.Drawing.Point(242, 3);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(211, 206);
            this.imgCapture.TabIndex = 1;
            this.imgCapture.TabStop = false;
            // 
            // imgVideo
            // 
            this.imgVideo.Location = new System.Drawing.Point(12, 3);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(211, 206);
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            // 
            // matbtnSource
            // 
            this.matbtnSource.AutoSize = true;
            this.matbtnSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnSource.Depth = 0;
            this.matbtnSource.Icon = null;
            this.matbtnSource.Location = new System.Drawing.Point(23, 361);
            this.matbtnSource.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnSource.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnSource.Name = "matbtnSource";
            this.matbtnSource.Primary = false;
            this.matbtnSource.Size = new System.Drawing.Size(115, 36);
            this.matbtnSource.TabIndex = 3;
            this.matbtnSource.Text = "Video Source";
            this.ChangeSetupTip.SetToolTip(this.matbtnSource, "This button will allow you to change \r\n      the settings of your cammera");
            this.matbtnSource.UseVisualStyleBackColor = true;
            this.matbtnSource.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // matbtnClear
            // 
            this.matbtnClear.AutoSize = true;
            this.matbtnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnClear.Depth = 0;
            this.matbtnClear.Icon = null;
            this.matbtnClear.Location = new System.Drawing.Point(424, 361);
            this.matbtnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnClear.Name = "matbtnClear";
            this.matbtnClear.Primary = false;
            this.matbtnClear.Size = new System.Drawing.Size(63, 36);
            this.matbtnClear.TabIndex = 5;
            this.matbtnClear.Text = "Clear";
            this.ClearTip.SetToolTip(this.matbtnClear, "This button will clear the text where \r\n   the users tag number is entered");
            this.matbtnClear.UseVisualStyleBackColor = true;
            this.matbtnClear.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // matlblError
            // 
            this.matlblError.AutoSize = true;
            this.matlblError.Depth = 0;
            this.matlblError.Font = new System.Drawing.Font("Roboto", 11F);
            this.matlblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matlblError.Location = new System.Drawing.Point(199, 70);
            this.matlblError.MouseState = MaterialSkin.MouseState.HOVER;
            this.matlblError.Name = "matlblError";
            this.matlblError.Size = new System.Drawing.Size(108, 19);
            this.matlblError.TabIndex = 6;
            this.matlblError.Text = "materialLabel1";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(23, 70);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(55, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Help";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_2);
            // 
            // frmEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 406);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.matlblError);
            this.Controls.Add(this.matbtnClear);
            this.Controls.Add(this.matbtnSource);
            this.Controls.Add(this.pnlCam);
            this.Controls.Add(this.matbtnSettings);
            this.Controls.Add(this.mattxtUserID);
            this.Name = "frmEntrance";
            this.Text = "Entrance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEntrance_FormClosed);
            this.Load += new System.EventHandler(this.frmEntrance_Load);
            this.pnlCam.ResumeLayout(false);
            this.pnlManual.ResumeLayout(false);
            this.pnlManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField mattxtUserID;
        private MaterialSkin.Controls.MaterialFlatButton matbtnSettings;
        private System.Windows.Forms.Panel pnlCam;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.PictureBox imgVideo;
        private MaterialSkin.Controls.MaterialFlatButton matbtnSource;
        private System.Windows.Forms.Panel pnlManual;
        private MaterialSkin.Controls.MaterialFlatButton matbtnAccept;
        private MaterialSkin.Controls.MaterialSingleLineTextField mattxtPlate;
        private MaterialSkin.Controls.MaterialFlatButton matbtnCancel;
        private System.Windows.Forms.ToolTip ChangeSetupTip;
        private System.Windows.Forms.ToolTip VideoSourceTip;
        private MaterialSkin.Controls.MaterialFlatButton matbtnClear;
        private MaterialSkin.Controls.MaterialLabel matlblError;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.ToolTip ClearTip;
    }
}