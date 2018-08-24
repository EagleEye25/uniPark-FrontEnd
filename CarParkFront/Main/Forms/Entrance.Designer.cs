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
            this.mattxtUserID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.matbtnSettings = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlCam = new System.Windows.Forms.Panel();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.matbtnSource = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlCam.SuspendLayout();
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
            this.matbtnSettings.UseVisualStyleBackColor = true;
            this.matbtnSettings.Click += new System.EventHandler(this.matbtnSettings_Click);
            // 
            // pnlCam
            // 
            this.pnlCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.pnlCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCam.Controls.Add(this.imgCapture);
            this.pnlCam.Controls.Add(this.imgVideo);
            this.pnlCam.Location = new System.Drawing.Point(23, 138);
            this.pnlCam.Name = "pnlCam";
            this.pnlCam.Size = new System.Drawing.Size(467, 214);
            this.pnlCam.TabIndex = 2;
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
            this.matbtnSource.UseVisualStyleBackColor = true;
            this.matbtnSource.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // frmEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 406);
            this.Controls.Add(this.matbtnSource);
            this.Controls.Add(this.pnlCam);
            this.Controls.Add(this.matbtnSettings);
            this.Controls.Add(this.mattxtUserID);
            this.Name = "frmEntrance";
            this.Text = "Entrance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEntrance_FormClosed);
            this.Load += new System.EventHandler(this.frmEntrance_Load);
            this.pnlCam.ResumeLayout(false);
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
    }
}