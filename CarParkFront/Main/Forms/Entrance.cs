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
using System.Diagnostics;
using System.IO;

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
        // Web cam dll and code obtained from WinFormCharpWebCam

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
            materialFlatButton2.Visible = false;
            if (File.Exists("Plate") == true)
            {
                //
            }
            else
            {
                StreamWriter swp = new StreamWriter("Plate.txt");
                swp.Close();
            }
            matlblError.Text = "";
            mattxtUserID.Focus();
            //    mattxtUserID.Text = "";
            StreamReader srS = new StreamReader("Settings.txt");

            string[] line = srS.ReadLine().Split(',');
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
            if (line[2] == "Y")
            {
                webcam.Start();
            }
            // Set output point for video

        // Start video
        //    webcam.Start();
            pnlManual.Visible = false;
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
            webcam.Stop();
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

            // Var declaration
            IDBHandler handler = new DBHandler();
            string userID = "", plate = "", gate, entrins = "", userIDField = "", gateID = "", plateIn = null, accuracy = "", line = "";
            DateTime time;
            int  logID, accessLevel, userAccess, length = 0;
            Image myImage;
            bool scanner = false, cam = false;

            // File format Gate Type, Gate ID, Cam, Scanner, Entrins Type
            StreamReader srS = new StreamReader("Settings.txt");

            string[] lines = srS.ReadLine().Split(',');

            // Get values from settings file
            gate = lines[0];
            gateID = lines[1];
            if (lines[2] == "Y")
                cam = true;
            if (lines[3] == "Y")
                scanner = true;
            entrins = lines[4];

            length = mattxtUserID.TextLength - 1;

            if ((mattxtUserID.TextLength > 0) && ((mattxtUserID.TextLength == 10) || (mattxtUserID.Text[length] == '#')))
            { // Begin Main if
                if (mattxtUserID.TextLength == 10)
                {
                    if (handler.BLL_checktag(mattxtUserID.Text) == null)
                    {
                        matlblError.Text = "User not found";
                        mattxtUserID.Text = "";
                        mattxtUserID.Focus();
                    }
                    else
                    {
                        // Gets user ID
                        uspGetPersonnelID id = new uspGetPersonnelID();
                        id = handler.BLL_PersonnelID(mattxtUserID.Text);
                        userID = id.PersonnelID;
                        

                        uspGetUserAccessLevel userLevel = handler.BLL_GetUserAccessLevel(userID);
                        userAccess = userLevel.PersonnelLevelID;

                        // runs process acording to settings file
                        if (gate == "M")
                        {
                            // Main Gate
                            if (entrins == "En")
                            {
                                // Entrins
                                if (cam == true)
                                {
                                    // Cam
                                       ImageCap();
                                    /*   StreamReader srP = new StreamReader("Plate.txt");
                                       string[] lines = srP.ReadLine().Split(',');
                                       string[] ac = lines[1].Split('.');
                                       plate = lines[0];
                                       accuracy = double.Parse(ac[0]);
                                       srP.Close();
                                       File.Delete(@"C: \Users\Wihan\Desktop\Wihan\NMMU\Project 3de Year\uniPark-FrontEnd\CarParkFront\bin\Debug\Plate.txt");
   */

                                    var proc = new Process
                                    {
                                        StartInfo = new ProcessStartInfo
                                        {
                                            FileName = "alpr.exe",
                                            Arguments = "-c za myImage.jpg",
                                            UseShellExecute = false,
                                            RedirectStandardOutput = true,
                                            CreateNoWindow = true
                                        }
                                    };
                                    proc.Start();

                                    int i = 0;
                               //     string line = "";
                               //     string accuracy = "";

                                    while (i++ < 2)
                                    {
                                        line = proc.StandardOutput.ReadLine().Trim().Trim('-').Trim();
                                        if (i > 1)
                                        {
                                            line = line.Replace("  ", "?");
                                            string[] split = line.Split('\t');
                                            line = split[0].Trim();
                                            accuracy = split[1].Trim();



                                        }
                                    }
                                    accuracy = accuracy.Split(' ')[1];
                                    accuracy = accuracy.Split('.')[0];
                                    plate = line;
                                    if (double.Parse(accuracy) > 85)
                                    {
                                        handler.BLL_AddPersonnelLog(userID, plate, DateTime.Now, int.Parse(gateID));
                                        matlblError.Text = "User Log Added";
                                        mattxtUserID.Text = "";
                                        mattxtUserID.Focus();

                                 //       File.Delete(@"C:\Users\Wihan\Desktop\Wihan\NMMU\Project 3de Year\uniPark-FrontEnd\CarPark\bin\Debug");
                                      //  File.Delete(@"C:\Users\Wihan\Desktop\Wihan\NMMU\Project 3de Year\uniPark-FrontEnd\CarParkFront\bin\Debug");
                                    }
                                    else
                                    {
                                        pnlManual.Visible = true;
                                        mattxtTagNum.Focus();

                                        if (mattxtUserID.Text[length] == '#')
                                        {
                                            mattxtTagNum.Text = mattxtUserID.Text.TrimEnd('#');
                                        }
                                        else
                                        {
                                            mattxtTagNum.Text = mattxtUserID.Text;
                                        }
                                        
                                        mattxtUserID.Enabled = false;
                                    }  
                                }
                                else if (cam == false)
                                {
                                    // No Cam
                                    // run usp
                                    plate = null;
                                    handler.BLL_AddPersonnelLog(userID, plate, DateTime.Now, int.Parse(gateID));
                                    matlblError.Text = "User Log Added";
                                    mattxtUserID.Text = "";
                                    mattxtUserID.Focus();
                                }
                            }
                            else if (entrins == "Ex")
                            {
                                // Exit
                                if (cam == true)
                                {
                                    // Cam
                                    uspGetPlate gp = handler.BLL_GetPlate(userID);
                                    plateIn = gp.LicenseIn;
                                    //

                                           ImageCap();
                                    /*       StreamReader srP = new StreamReader("Plate.txt",true);
                                           string[] lines = srP.ReadLine().Split(',');
                                           string[] ac = lines[1].Split('.');
                                           plate = lines[0];
                                           accuracy = double.Parse(ac[0]);
                                           srP.Close(); */
                                    //     File.Delete(@"C: \Users\Wihan\Desktop\Wihan\NMMU\Project 3de Year\uniPark-FrontEnd\CarParkFront\bin\Debug\Plate.txt");

                                    var proc = new Process
                                    {
                                        StartInfo = new ProcessStartInfo
                                        {
                                            FileName = "alpr.exe",
                                            Arguments = "-c za myImage.jpg",
                                            UseShellExecute = false,
                                            RedirectStandardOutput = true,
                                            CreateNoWindow = true
                                        }
                                    };
                                    proc.Start();

                                    int i = 0;
                                    //     string line = "";
                                    //     string accuracy = "";

                                    while (i++ < 2)
                                    {
                                        line = proc.StandardOutput.ReadLine().Trim().Trim('-').Trim();
                                        if (i > 1)
                                        {
                                            line = line.Replace("  ", "?");
                                            string[] split = line.Split('\t');
                                            line = split[0].Trim();
                                            accuracy = split[1].Trim();



                                        }
                                    }
                                    accuracy = accuracy.Split(' ')[1];
                                    accuracy = accuracy.Split('.')[0];
                                    plate = line;
                                    if (double.Parse(accuracy) > 85)
                                    {
                                        if (plateIn == null || plateIn != plate)
                                        {
                                            matlblError.Text = "User did not enter with this car";
                                        }
                                        else if (plateIn == plate)
                                        {
                                            handler.BLL_UpdatePersonnelLog(userID, plate, DateTime.Now);
                                            matlblError.Text = "User Log Added";
                                            mattxtUserID.Text = "";
                                            mattxtUserID.Focus();
                                        }

                                    }
                                    else
                                    {
                                        pnlManual.Visible = true;
                                        mattxtTagNum.Focus();
                                        if (mattxtUserID.Text[length] == '#')
                                        {
                                            mattxtTagNum.Text = mattxtUserID.Text.TrimEnd('#');
                                        }
                                        else
                                        {
                                            mattxtTagNum.Text = mattxtUserID.Text;
                                        }
                                        
                                        mattxtUserID.Enabled = false;
                                    }

                                }
                                else if (cam == false)
                                {
                                    // No Cam
                                    // run usp
                                    plate = null;
                                    handler.BLL_UpdatePersonnelLog(userID, plate, DateTime.Now);
                                    matlblError.Text = "User Log Added";
                                    mattxtUserID.Text = "";
                                    mattxtUserID.Focus();
                                }
                            }
                            else
                            {
                                matlblError.Text = "Gate type was not found \n Try changing the setup";
                            }
                        } // End Main Gate if
                        else if (gate == "A")
                        {

                            //Get LogID
                            uspGetLogID log = handler.BLL_GetLogID(userID);
                            logID = log.PersonnelLogID;
                            uspGetAccessLevel access = handler.BLL_GetAccessLevel(gateID);
                            accessLevel = access.ParkingAreaAccessLevel;

                            if (userAccess >= accessLevel)
                            {
                                // Parking Area
                                if (entrins == "En")
                                {
                                    // Entrins
                                    if (cam == true)
                                    {
                                        // Cam
                                        matlblError.Text = "Somthing whent wrong.\n A parking area kan not have a cammera connected";
                                    }
                                    else if (cam == false)
                                    {
                                        // No Cam
                                        // run usp
                                        handler.BLL_AddParkingLog(gateID,logID,DateTime.Now);
                                        matlblError.Text = "User Log Added";
                                        mattxtUserID.Text = "";
                                        mattxtUserID.Focus();
                                    }
                                }
                                else if (entrins == "Ex")
                                {
                                    // Exit
                                    if (cam == true)
                                    {
                                        // Cam
                                        matlblError.Text = "Somthing whent wrong.\n A parking area kan not have a cammera connected";
                                    }
                                    else if (cam == false)
                                    {
                                        // No Cam
                                        // run usp
                                        handler.BLL_UpdateParkingLog(logID, DateTime.Now);
                                        matlblError.Text = "User Log Added";
                                        mattxtUserID.Text = "";
                                        mattxtUserID.Focus();
                                    }
                                }
                                else
                                {
                                    matlblError.Text = "Gate type was not found \n Try changing the setup";
                                }
                            
                            }
                            else
                            {
                                matlblError.Text = "User does not have access to the parking area";
                            }

                        } // End Parking area if
                        else
                        {
                            matlblError.Text = "Gate type not found \n Try changing the setup";
                            //
                        }
                    }
                }
                else if (mattxtUserID.TextLength == 5 && mattxtUserID.Text[4] == '#')
                {
                    if (handler.BLL_CheckGuest(mattxtUserID.Text.TrimEnd('#')) == null)
                    {
                        matlblError.Text = "User not found";
                        mattxtUserID.Text = "";
                        mattxtUserID.Focus();
                    }
                    else
                    {
                        // Gets user ID
                        userID = mattxtUserID.Text.TrimEnd('#');
                        

                        uspGetUserAccessLevel userLevel = handler.BLL_GetUserAccessLevel(userID);
                        userAccess = userLevel.PersonnelLevelID;

                        // runs process acording to settings file
                        if (gate == "M")
                        {
                            // Main Gate
                            if (entrins == "En")
                            {
                                // Entrins
                                if (cam == true)
                                {
                                    // Cam
                                                    ImageCap();
                                    /*                StreamReader srP = new StreamReader("Plate.txt");
                                                    string[] lines2 = srP.ReadLine().Split(',');
                                                    string[] ac = lines2[1].Split('.');
                                                    plate = lines2[0];
                                                    accuracy = double.Parse(ac[0]); */


                                    var proc = new Process
                                    {
                                        StartInfo = new ProcessStartInfo
                                        {
                                            FileName = "alpr.exe",
                                            Arguments = "-c za myImage.jpg",
                                            UseShellExecute = false,
                                            RedirectStandardOutput = true,
                                            CreateNoWindow = true
                                        }
                                    };
                                    proc.Start();

                                    int i = 0;
                                    //     string line = "";
                                    //     string accuracy = "";

                                    while (i++ < 2)
                                    {
                                        line = proc.StandardOutput.ReadLine().Trim().Trim('-').Trim();
                                        if (i > 1)
                                        {
                                            line = line.Replace("  ", "?");
                                            string[] split = line.Split('\t');
                                            line = split[0].Trim();
                                            accuracy = split[1].Trim();



                                        }
                                    }
                                    accuracy = accuracy.Split(' ')[1];
                                    accuracy = accuracy.Split('.')[0];
                                    if (double.Parse(accuracy) > 85)
                                    {
                                        handler.BLL_AddPersonnelLog(userID, plate, DateTime.Now, int.Parse(gateID));
                                        matlblError.Text = "User Log Added";
                                        mattxtUserID.Text = "";
                                        mattxtUserID.Focus();
                                    }
                                    else
                                    {
                                        pnlManual.Visible = true;
                                        mattxtTagNum.Focus();
                                        mattxtTagNum.Text = mattxtUserID.Text;
                                        mattxtUserID.Enabled = false;
                                    }
                                }
                                else if (cam == false)
                                {
                                    // No Cam
                                    // run usp
                                    plate = null;
                                    handler.BLL_AddPersonnelLog(userID, plate, DateTime.Now, int.Parse(gateID));
                                    matlblError.Text = "User Log Added";
                                    mattxtUserID.Text = "";
                                    mattxtUserID.Focus();
                                }
                            }
                            else if (entrins == "Ex")
                            {
                                // Exit
                                if (cam == true)
                                {
                                    // Cam
                                    uspGetPlate gp = handler.BLL_GetPlate(userID);
                                    plateIn = gp.LicenseIn;
                                    //

                                            ImageCap();
                                    /*        StreamReader srP = new StreamReader("Plate.txt");

                                            MessageBox.Show(srP.ReadLine());
                                            string[] lines = srP.ReadLine().Split(',');
                                            string[] ac = lines[1].Split('.');
                                            plate = lines[0];
                                            accuracy = double.Parse(ac[0]); */


                                    var proc = new Process
                                    {
                                        StartInfo = new ProcessStartInfo
                                        {
                                            FileName = "alpr.exe",
                                            Arguments = "-c za myImage.jpg",
                                            UseShellExecute = false,
                                            RedirectStandardOutput = true,
                                            CreateNoWindow = true
                                        }
                                    };
                                    proc.Start();

                                    int i = 0;
                                    //     string line = "";
                                    //     string accuracy = "";

                                    while (i++ < 2)
                                    {
                                        line = proc.StandardOutput.ReadLine().Trim().Trim('-').Trim();
                                        if (i > 1)
                                        {
                                            line = line.Replace("  ", "?");
                                            string[] split = line.Split('\t');
                                            line = split[0].Trim();
                                            accuracy = split[1].Trim();


                                        }
                                    }
                                    accuracy = accuracy.Split(' ')[1];
                                    accuracy = accuracy.Split('.')[0];
                                    plate = line;
                                    if (double.Parse(accuracy) > 85) 
                                    {
                                        if (plateIn == null || plateIn != plate)
                                        {
                                            matlblError.Text = "User did not enter with this car";
                                        }
                                        else if (plateIn == plate)
                                        {
                                            handler.BLL_UpdatePersonnelLog(userID, plate, DateTime.Now);
                                            matlblError.Text = "User Log Added";
                                            mattxtUserID.Text = "";
                                            mattxtUserID.Focus();
                                        }

                                    }
                                    else
                                    {
                                        pnlManual.Visible = true;
                                        mattxtTagNum.Focus();
                                        mattxtTagNum.Text = mattxtUserID.Text;
                                        mattxtUserID.Enabled = false;
                                    }

                                }
                                else if (cam == false)
                                {
                                    // No Cam
                                    // run usp
                                    plate = null;
                                    handler.BLL_UpdatePersonnelLog(userID, plate, DateTime.Now);
                                    matlblError.Text = "User Log Added";
                                    mattxtUserID.Text = "";
                                    mattxtUserID.Focus();
                                }
                            }
                            else
                            {
                                matlblError.Text = "Gate type was not found \n Try changing the setup";
                            }
                        } // End Main Gate if
                        else if (gate == "A")
                        {

                            //Get LogID
                            uspGetLogID log = handler.BLL_GetLogID(userID);
                            logID = log.PersonnelLogID;
                            uspGetAccessLevel access = handler.BLL_GetAccessLevel(gateID);
                            accessLevel = access.ParkingAreaAccessLevel;

                            if (userAccess >= accessLevel)
                            {
                                // Parking Area
                                if (entrins == "En")
                                {
                                    // Entrins
                                    if (cam == true)
                                    {
                                        // Cam
                                        matlblError.Text = "Somthing whent wrong.\n A parking area kan not have a cammera connected";
                                    }
                                    else if (cam == false)
                                    {
                                        // No Cam
                                        // run usp
                                        handler.BLL_AddParkingLog(gateID, logID, DateTime.Now);
                                        matlblError.Text = "User Log Added";
                                        mattxtUserID.Text = "";
                                        mattxtUserID.Focus();
                                    }
                                }
                                else if (entrins == "Ex")
                                {
                                    // Exit
                                    if (cam == true)
                                    {
                                        // Cam
                                        matlblError.Text = "Somthing whent wrong.\n A parking area kan not have a cammera connected";
                                    }
                                    else if (cam == false)
                                    {
                                        // No Cam
                                        // run usp
                                        handler.BLL_UpdateParkingLog(logID, DateTime.Now);
                                        matlblError.Text = "User Log Added";
                                        mattxtUserID.Text = "";
                                        mattxtUserID.Focus();
                                    }
                                }
                                else
                                {
                                    matlblError.Text = "Gate type was not found \n Try changing the setup";
                                }

                            }
                            else
                            {
                                matlblError.Text = "User does not have access to the parking area";
                            }

                        } // End Parking area if
                        else
                        {
                            matlblError.Text = "Gate type not found \n Try changing the setup";
                            //
                        }
                    }
                }
 
                
            } // End main if  
            srS.Close();

        } // End private void mattxtUserID_TextChanged

        private void mattxtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            //
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            webcam.AdvanceSetting();
        }

        // method to capture immage and run license plat recog
        public void ImageCap()
        {
            Image myImage;

            imgCapture.Image = imgVideo.Image;
            myImage = imgCapture.Image;
            myImage.Save(@"C:\Users\Wihan\Desktop\Wihan\NMMU\Project 3de Year\uniPark-FrontEnd\CarParkFront\bin\Debug\myImage.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
           // myImage.Save(@"C:\Users\Wihan\Desktop\Wihan\NMMU\Project 3de Year\uniPark-FrontEnd\CarPark\bin\Debug\myImage.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }

        private void matbtnAccept_Click(object sender, EventArgs e)
        {
            // Var declaration
            IDBHandler handler = new DBHandler();
            string userID = "", plate = "", gate, entrins = "", userIDField = "", gateID = "", plateIn = null;
            DateTime time;
            int logID, accessLevel, userAccess;
            Image myImage;
            bool scanner = false, cam = false;
            double accuracy;

            // File format Gate Type, Gate ID, Cam, Scanner, Entrins Type
            StreamReader srS = new StreamReader("Settings.txt");

            string[] line = srS.ReadLine().Split(',');

            // Get values from settings file
            gate = line[0];
            gateID = line[1];
            if (line[2] == "Y")
                cam = true;
            if (line[3] == "Y")
                scanner = true;
            entrins = line[4];

            if ((mattxtUserID.TextLength == 10))
            {
                // Gets user ID
                uspGetPersonnelID id = new uspGetPersonnelID();
                id = handler.BLL_PersonnelID(mattxtUserID.Text);
                userID = id.PersonnelID;
            }
            else if ((mattxtUserID.TextLength == 5 && mattxtUserID.Text[4] == '#'))
            {
                // Gets user ID
                uspGetPersonnelID id = new uspGetPersonnelID();
                userID = mattxtUserID.Text;
          //      id = handler.BLL_PersonnelID(mattxtUserID.Text.TrimEnd('#'));
          //      userID = id.PersonnelID;

                }

            plate = mattxtPlate.Text;

            if (gate == "M")
            {
                // Main Gate
                if (entrins == "En")
                {
                    // Entrins
                    handler.BLL_AddPersonnelLog(userID, plate, DateTime.Now, int.Parse(gateID));
                    matlblError.Text = "User Log Added";

                }
                else if (entrins == "Ex")
                {
                    // Exit
                    uspGetPlate gp = handler.BLL_GetPlate(userID);
                    plateIn = gp.LicenseIn;

                    if (plateIn == null || plateIn != plate)
                    {
                        matlblError.Text = "User did not enter with this car";
                    }
                    else if (plateIn == plate)
                    {

                        handler.BLL_UpdatePersonnelLog(userID, plate, DateTime.Now);
                        matlblError.Text = "User Log Added";
                    }
                }
            }
            else if (gate == "A")
            {
                uspGetLogID log = handler.BLL_GetLogID(userID);
                logID = log.PersonnelLogID;
                uspGetAccessLevel access = handler.BLL_GetAccessLevel(gateID);
                accessLevel = access.ParkingAreaAccessLevel;
                if (entrins == "En")
                {
                    handler.BLL_AddParkingLog(gateID, logID, DateTime.Now);
                    matlblError.Text = "User Log Added";
                }
                else if (entrins == "Ex")
                {
                    handler.BLL_UpdateParkingLog(logID, DateTime.Now);
                    matlblError.Text = "User Log Added";
                }
            }

            mattxtUserID.Enabled = true;
            mattxtPlate.Text = "Enter plate number";
            mattxtTagNum.Text = "Enter tag number";
            mattxtUserID.Text = "";
            mattxtUserID.Focus();
            pnlManual.Visible = false;
        }

        private void matbtnCancel_Click_1(object sender, EventArgs e)
        {

            mattxtUserID.Enabled = true;
            mattxtPlate.Text = "Enter plate number";
            mattxtTagNum.Text = "Enter tag number";
            mattxtUserID.Text = "";
            mattxtUserID.Focus();
            pnlManual.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            mattxtUserID.Text = "";
            mattxtUserID.Focus();

        }

        private void materialFlatButton1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("This form is where you can add users to a log \nof people that enter and exits the gate. \n \nTo see what the buttons will do hold your mouse pointer over a button for its description to show");
        }

        private void matbtnManual_Click_1(object sender, EventArgs e)
        {
            pnlManual.Visible = true;
            materialFlatButton2.Focus();
            mattxtUserID.Enabled = false;
            
        }
    }
}


