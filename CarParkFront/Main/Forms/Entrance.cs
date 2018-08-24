using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
//using TypeLib.Models;
using TypeLib.ViewModels;
using TypeLib.Interfaces;
using CarPark_BLL;

namespace CarParkFront.Main.Forms
{
    public partial class frmEntrance : MaterialForm
    {
        public frmEntrance()
        {
            InitializeComponent();
        // Set MaterialSkin Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green800,
                Primary.Green900,
                Primary.Green500,
                Accent.Green200,
                TextShade.BLACK);
        }
        // Initialize WebCam class
        WebCam webcam;

        private void PanelVisible(string panelName)
        {
            List<Panel> landingPanels = new List<Panel>();
            landingPanels.Add(pnlCam);


            foreach (Panel p in landingPanels)
            {
                if (p.Name == panelName)
                {
                    p.Visible = true;
                   // p.Dock = DockStyle.Fill;
                }
                else
                    p.Visible = false;
            }
        }

        private void frmEntrance_Load(object sender, EventArgs e)
        {
            mattxtUserID.Focus();
        //    mattxtUserID.Text = "";
             
        // Set output point for video
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
        // Start video
            webcam.Start();
        }

        private void frmEntrance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mattxtUserID_Leave(object sender, EventArgs e)
        {
            /* will set text field back to message if user doesnt enter data */
            if (mattxtUserID.Text != "")
                mattxtUserID.Text = mattxtUserID.Text;
            else
                mattxtUserID.Text = "Enter User ID";
        }

        private void mattxtUserID_Click(object sender, EventArgs e)
        {
            /* Sets text to nothing */
            mattxtUserID.Text = "";
        }

        private void mattxtUserID_Enter(object sender, EventArgs e)
        {
            mattxtUserID.Text = "";

        }

        private void matbtnManual_Click(object sender, EventArgs e)
        {
        }

        private void matbtnSettings_Click(object sender, EventArgs e)
        {
            frmEntrance entrance = this;
            frmSetup setup = new frmSetup();
            entrance.Hide();
            setup.Show();


        }

        private void matbtnCancel_Click(object sender, EventArgs e)
        {
        }

        private void mattxtPlateNumber_Click(object sender, EventArgs e)
        {
        }

        private void mattxtPlateNumber_Leave(object sender, EventArgs e)
        {
        }

        private void mattxtUserID_TextChanged(object sender, EventArgs e)
        {
            IDBHandler handler = new DBHandler();

            if (mattxtUserID.TextLength == 10)
            {
                if (handler.BLL_checktag(mattxtUserID.Text) == null)
                {
                    MessageBox.Show("guest verification id valid");
                }
                else
                {
                    imgCapture.Image = imgVideo.Image;

                }

            }
        }

        private void mattxtUserID_KeyDown(object sender, KeyEventArgs e)
        {
//
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            webcam.AdvanceSetting();
        }
    }
}
