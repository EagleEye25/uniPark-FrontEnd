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
using System.IO;
using TypeLib.ViewModels;
using TypeLib.Interfaces;
using CarPark_BLL;

namespace CarParkFront.Main.Forms
{
    public partial class frmSetup : MaterialForm
    {
        public frmSetup()
        {
            InitializeComponent();

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



    private void frmSetup_Load(object sender, EventArgs e)
        {
            // If settings file exists
            if (File.Exists("Settings.txt"))
            {
                // File format Gate Type, Gate ID, Cam, Scanner, Entrins Type
                StreamReader sr = new StreamReader("Settings.txt");
                string[] line = sr.ReadLine().Split(',');
            //    File.Delete(@"C: \Users\Wihan\Desktop\Wihan\NMMU\Project 3de Year\uniPark-FrontEnd\CarParkFront\bin\Debug\Plate.txt");

                // Gate                   
                if (line[0] == "M") // Main Gate
                {
                    rdoGate.Select();
                }
                else if (line[0] == "A") // Parking Area
                {
                    rdoArea.Select();
                }

                // Gate ID

                cbxName.SelectedValue = line[1];
                
                // Scanner
                if (line[3] == "Y")
                {
                    rdoEnableScan.Select();
                } 
                else if (line[3] == "N")
                {
                    rdoDisableScan.Select();
                }

                // Cam
                if (line[2] == "Y")
                {
                    rdoEnableCam.Select();
                }
                else if (line[2] == "N")
                {
                    rdoDisableCam.Select();
                }

                // Entrins Type
                if (line[4] == "Ex")
                {
                    rdoExit.Select();
                }
                else if (line[4] == "En")
                {
                    rdoEntrance.Select();
                }
                sr.Close();
            }
            
            
        }

        private void materialRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            IDBHandler handler = new DBHandler();

            DataTable dt = new DataTable();
            dt = handler.BLL_GetMainGate();

            cbxName.DataSource = dt;
            cbxName.DisplayMember = "Gate";
            cbxName.ValueMember = "GateID";

            pnlMainGate.Visible = true;
            lblDesc.Text = "Main Gate";
            rdoDisableCam.Select();
            rdoDisableScan.Select();
            rdoDisableCam.Enabled = false;
            rdoEnableCam.Enabled = false;
            rdoDisableScan.Enabled = true;
            rdoEnableScan.Enabled = true;

        }

        private void materialRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            IDBHandler handler = new DBHandler();

            DataTable dt = new DataTable();
            dt = handler.BLL_GetAllAreas();

            cbxName.DataSource = dt;
            cbxName.DisplayMember = "Area";
            cbxName.ValueMember = "AreaID";

            pnlMainGate.Visible = true;
            lblDesc.Text = "Parking Area";
            rdoDisableCam.Enabled = false;
            rdoEnableCam.Enabled = false;
            rdoDisableScan.Enabled = true;
            rdoEnableScan.Enabled = true;

            rdoDisableCam.Select();
            rdoDisableScan.Select();
            

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string path = "Settings.txt";
            string scanner = "", cam = "", exit = "", gate = "", gateID = "";

            // Cam
            if (rdoEnableCam.Checked == true)
            {
                cam = "Y"; // Yes
            }
            else if (rdoDisableCam.Checked == true)
            {
                cam = "N"; // No
            }

            // Scanner
            if (rdoEnableScan.Checked == true)
            {
                scanner = "Y"; // Yes
            }
            else if (rdoDisableScan.Checked == true)
            {
                scanner = "N"; // No
            }

            // Gate
            if (rdoArea.Checked == true)
            {
                gate = "A"; // Area
            }
            else if (rdoGate.Checked == true)
            {
                gate = "M"; // Main Gate
            }

            // Gate ID
            gateID = cbxName.SelectedValue.ToString();


                 if ( rdoEntrance.Checked == false && rdoExit.Checked == false)
                 {
                     MessageBox.Show("Please select whether gate is a entrance or a exit");
                 }
                 else
                 {
                     // Exit
                     if (rdoExit.Checked == true)
                     {
                         exit = "Ex"; //Exit
                     }
                     else if (rdoEntrance.Checked == true)
                     {
                         exit = "En"; // Entrance
                     }
                // File format Gate Type, Gate ID, Cam, Scanner, Entrins Type
                    System.IO.File.WriteAllText(path, gate + ',' + gateID + ',' + cam + ',' + scanner + ',' + exit);

                     frmEntrance entrance = new frmEntrance();
                     frmSetup setup = this;
                     setup.Hide();
                     entrance.Show();
                 } 
               
        }

        private void frmSetup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void matbtnSource_Click(object sender, EventArgs e)
        {
           //  webcam.AdvanceSetting();
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void rdoEnableScan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoArea.Checked == true)
            {
                rdoDisableCam.Select();
                rdoDisableCam.Enabled = false;
                rdoEnableCam.Enabled = false;
            }
            else
            {
                rdoDisableCam.Select();
                rdoDisableCam.Enabled = true;
                rdoEnableCam.Enabled = true;
            }

        }

        private void rdoDisableScan_CheckedChanged(object sender, EventArgs e)
        {
            rdoDisableCam.Select();
            rdoDisableCam.Enabled = false;
            rdoEnableCam.Enabled = false;
        }
    }
}
