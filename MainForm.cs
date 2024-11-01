namespace VehiPark1._1
{
    public partial class MainForm : Form
    {
        private Stack<Panel> panelHistory = new Stack<Panel>();

        private void ShowPanel(Panel panelToShow)
        {
            // Push the current panel to the history stack if it's not one of the restricted panels
            Panel currentPanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Visible);
            if (currentPanel != null && currentPanel != panelToShow && !splashPanel.Contains(currentPanel))
            {
                panelHistory.Push(currentPanel);
                currentPanel.Visible = false; // Hide the current panel
            }

            // Show the specified panel
            panelToShow.Visible = true;


            // Hide all panels
            splashPanel.Visible = false;
            menuPanel.Visible = false;
            scanOptionsPanel.Visible = false;
            newStudentPanel.Visible = false;
            scanStudentEndPanel.Visible = false;
            rfidScanPanel.Visible = false;
            manualInputPanel.Visible = false;
            ManualDNumberPanel.Visible = false;
            correctStudentPanel.Visible = false;
            ManualLicensePlatePanel.Visible = false;
            scanStudentTempVehicle.Visible = false;
            scanStudentAddPlateNumber.Visible = false;
            scanStudentNotFound.Visible = false;
            //  addStudent.Visible = false;


            // Show the specified panel
            panelToShow.Visible = true;

            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.splashPanel);
            this.Controls.Add(this.scanOptionsPanel);
            this.Controls.Add(this.newStudentPanel);
            this.Controls.Add(this.scanStudentEndPanel);
            this.Controls.Add(this.rfidScanPanel);
            this.Controls.Add(this.manualInputPanel);
            this.Controls.Add(this.ManualDNumberPanel);
            this.Controls.Add(this.correctStudentPanel);
            this.Controls.Add(this.ManualLicensePlatePanel);
            this.Controls.Add(this.scanStudentTempVehicle);
            this.Controls.Add(this.scanStudentAddPlateNumber);
            this.Controls.Add(this.scanStudentNotFound);

        }


        public MainForm()
        {
            InitializeComponent();
        }



        private void Btnsplashscreen_Click_1(object sender, EventArgs e)
        {
            //  splashPanel.Visible = false;
            //  menuPanel.Visible = true;
            ShowPanel(menuPanel);
        }


        private void scanStudentbtn_Click(object sender, EventArgs e)
        {
            ShowPanel(scanOptionsPanel);
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            // Check if there is any panel in the history stack
            if (panelHistory.Count > 0)
            {
                // Pop the last panel from the history stack and show it
                Panel previousPanel = panelHistory.Pop();
                ShowPanel(previousPanel);
            }
            else
            {
                MessageBox.Show("No previous panel to go back to.", "Back Button");
            }
        }

        private void newStudentBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(newStudentPanel);
        }

        private void bckBtn3_Click(object sender, EventArgs e)
        {
            // Check if there is any panel in the history stack
            if (panelHistory.Count > 0)
            {
                // Pop the last panel from the history stack and show it
                Panel previousPanel = panelHistory.Pop();
                ShowPanel(previousPanel);
            }
            else
            {
                MessageBox.Show("No previous panel to go back to.", "Back Button");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addStudentbtn_Click(object sender, EventArgs e)
        {
            // Check if any of the textboxes are empty
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtStudentNumber.Text) ||
                string.IsNullOrWhiteSpace(txtLicensePlate.Text))
            {
                // Display error message
                MessageBox.Show("Please fill out all fields before adding the student.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            ShowPanel(scanStudentEndPanel);

            // Optionally clear the textboxes after adding
            txtStudentName.Clear();
            txtStudentNumber.Clear();
            txtLicensePlate.Clear();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(menuPanel);
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnIDScan_Click_1(object sender, EventArgs e)
        {
            ShowPanel(rfidScanPanel);

        }

        private void btnManualScan_Click(object sender, EventArgs e)
        {

            ShowPanel(manualInputPanel);

        }



        private void ShowRFIDScanPanel()
        {
            // Show the RFID scan panel and set focus to the hidden text box
            rfidScanPanel.Visible = true;
            txtRFIDInput.Focus();
        }
        private void ShowScanStudentEndPanel()
        {
            // Hide all panels first
            splashPanel.Visible = false;
            menuPanel.Visible = false;
            scanOptionsPanel.Visible = false;
            newStudentPanel.Visible = false;
            rfidScanPanel.Visible = false;

            // Show the scanStudentEndPanel
            scanStudentEndPanel.Visible = true;

        }

        //temporary RFID tap simulation
        private void label6_Click_1(object sender, EventArgs e)
        {
            ShowPanel(scanStudentEndPanel);
        }

        private void inputIDNumbtn_Click(object sender, EventArgs e)
        {
            ShowPanel(ManualDNumberPanel);
        }

        private void inputLicensePlatebtn_Click(object sender, EventArgs e)
        {
            ShowPanel(ManualLicensePlatePanel);
        }

        private void chkStudentbtn_Click(object sender, EventArgs e)
        {
            // Check if any of the textboxes are empty
            if (string.IsNullOrWhiteSpace(txtStudentNum2.Text))
            {
                // Display error message
                MessageBox.Show("Please fill out ID Number.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            ShowPanel(correctStudentPanel);

        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(scanStudentEndPanel);
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(scanOptionsPanel);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void chkLicensebtn_Click(object sender, EventArgs e)
        {
            // Check if any of the textboxes are empty
            if (string.IsNullOrWhiteSpace(txtLicensePlate2.Text))
            {
                // Display error message
                MessageBox.Show("Please fill out License Plate Number.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            ShowPanel(correctStudentPanel);

        }

        private void correctStudentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkStudentLicense_Click(object sender, EventArgs e)
        {
            // Check if any of the textboxes are empty
            if (string.IsNullOrWhiteSpace(txtTempVehicleIDNum.Text))
            {
                // Display error message
                MessageBox.Show("Please fill out Student ID Number.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            ShowPanel(correctStudentPanel);

        }

        private void yesAddPlate_Click(object sender, EventArgs e)
        {
            ShowPanel(scanStudentTempVehicle);
        }

        private void noAddPlate_Click(object sender, EventArgs e)
        {
            ShowPanel(scanOptionsPanel);
        }

        private void yesNotFound_Click(object sender, EventArgs e)
        {
            ShowPanel(scanStudentEndPanel);
        }

        private void noNotFound_Click(object sender, EventArgs e)
        {
            ShowPanel(scanOptionsPanel);
        }





        //method to check if RFID is valid
        /*private void ProcessScannedID(string scannedID)
        {
            bool isValidStudent = CheckStudentID(scannedID);
            if (isValidStudent)
            {
                MessageBox.Show("Student successfully recorded!", "Success");

                // Move to the scanStudentEndPanel after successful recording
                ShowScanStudentEndPanel();
            }
            else
            {
                MessageBox.Show("Invalid Student ID.", "Error");
            } */



    }
} // namespace end

