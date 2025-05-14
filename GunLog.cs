using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunLog
{
    public partial class GunLog : Form
    {
        public GunLog()
        {
            InitializeComponent();
            GunDatabase.initializeDatabase();
            gunLoader();

        }
        void gunLoader()
        {
            GunListBox.Items.Clear();
            List<Gun> guns = GunDatabase.GetAllGuns();
            foreach (var gunItem in guns)
            {
                GunListBox.Items.Add(gunItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GunListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GunListBox.SelectedIndex != -1)
            {
                Gun selectedGun = (Gun)GunListBox.SelectedItem;

                SerialBox.Text = selectedGun.serial;
                MakeBox.Text = selectedGun.make;
                ModelBox.Text = selectedGun.model;
                CaliberBox.Text = selectedGun.caliber;
                PriceBox.Text = selectedGun.price.ToString();
                AcquiredBox.Text = selectedGun.dateAcquired;
            }
        }
        private bool checkPrice(string input)
        {
            int iPrice = 0;
            float fPrice = 0;
            int iOutput = 0;
            float fOutput = 0;
            bool isValid = false;
            bool isInt = false;
            bool isFloat = false;
            bool isPositive = false;


            //checks if input is numbers
            isInt = int.TryParse(input, out iOutput);
            isFloat = float.TryParse(input, out fOutput);

            //checks if int is positive
            if (isInt)
                iPrice = Int32.Parse(input);
            if (iPrice > 0)
                isPositive = true;
            if (isFloat)
                fPrice = float.Parse(input);
            if (fPrice > 0)
                isPositive = true;

            //cehcks overall validity
            if (isPositive && (isFloat || isInt))
                isValid = true;

            return isValid;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (string.IsNullOrEmpty(SerialBox.Text)) //checks emptiness
                errorMsg += "Serial cannot be empty\n";
            if (string.IsNullOrEmpty(MakeBox.Text)) //checks emptiness
                errorMsg += "Make cannot be empty\n";
            if (string.IsNullOrWhiteSpace(ModelBox.Text)) //checks emptiness
                errorMsg += "Model cannot be empty\n";
            if (string.IsNullOrWhiteSpace(CaliberBox.Text)) //checks emptiness
                errorMsg += "Caliber cannot be empty\n";
            if (!checkPrice(PriceBox.Text)) //runs the checkPrice function
                errorMsg += "Price cannot be empty and must be a non-negative number\n";
            if (string.IsNullOrWhiteSpace(AcquiredBox.Text)) //checks emptiness
                errorMsg += "Date cannot be empty\n";

            if (!string.IsNullOrWhiteSpace(errorMsg))
            {
                MessageBox.Show(errorMsg, "Error");//error message
            }
            else
            {
                double parsedPrice = double.Parse(PriceBox.Text);
                Gun newGun = new Gun(SerialBox.Text, MakeBox.Text, ModelBox.Text, CaliberBox.Text, 0, parsedPrice, AcquiredBox.Text);
                GunDatabase.InsertGun(newGun);
                gunLoader();
            }

            SerialBox.Clear();
            MakeBox.Clear();
            ModelBox.Clear();
            CaliberBox.Clear();
            PriceBox.Clear();
            AcquiredBox.Clear();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (GunListBox.SelectedIndex == -1)// error if no selection/fields are blank or invalid
                MessageBox.Show("Must select a book to edit", "Error");
            else if (string.IsNullOrWhiteSpace(MakeBox.Text) || string.IsNullOrWhiteSpace(ModelBox.Text) ||
                    string.IsNullOrWhiteSpace(CaliberBox.Text) || !checkPrice(PriceBox.Text) || string.IsNullOrWhiteSpace(AcquiredBox.Text))
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }
            else if (GunListBox.SelectedItem is Gun selectedGun)
            {
                double parsedPrice = double.Parse(PriceBox.Text);

                selectedGun.serial = SerialBox.Text;
                selectedGun.make = MakeBox.Text;
                selectedGun.model = ModelBox.Text;
                selectedGun.caliber = CaliberBox.Text;
                selectedGun.price = parsedPrice;
                selectedGun.dateAcquired = AcquiredBox.Text;

                GunDatabase.UpdateGun(selectedGun);
                gunLoader();
            }

            SerialBox.Clear();
            MakeBox.Clear();
            ModelBox.Clear();
            CaliberBox.Clear();
            PriceBox.Clear();
            AcquiredBox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (GunListBox.SelectedIndex != -1)
            {
                Gun selection = (Gun)GunListBox.SelectedItem;
                GunDatabase.DeleteGunBySerial(selection.serial);
                gunLoader();
            }
            else
                MessageBox.Show("Must select a gun to delete", "Error");
        }

        private void AddRoundButton_Click(object sender, EventArgs e)
        {
            if (GunListBox.SelectedIndex != -1)
            {
                Gun selectedGun = (Gun)GunListBox.SelectedItem;

                DialogResult DialogResult = MessageBox.Show(
                    "Are you sure you want to add rounds fired?",
                    "Confirm Round Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    int parsedRounds = int.Parse(RoundsBox.Text);
                    int roundCount = selectedGun.roundCount;

                    roundCount += parsedRounds;

                    GunDatabase.UpdateRoundCount(selectedGun.serial, roundCount);
                    gunLoader();

                    SerialBox.Clear();
                    MakeBox.Clear();
                    ModelBox.Clear();
                    CaliberBox.Clear();
                    PriceBox.Clear();
                    AcquiredBox.Clear();
                    RoundsBox.Clear();
                }
            }
            else
                MessageBox.Show("Please select a gun first.");
        }
    }
}
