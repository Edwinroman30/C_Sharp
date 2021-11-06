using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private bool isValid;
        private readonly CarRentalEntities2 carRentalEntities;

        public Form1()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities2();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Puedo crear una clase que encapsule esto.

                string CustomerName = tboxCustomer.Text;
                float Cost = float.Parse(tboxCost.Text);
                var dateRented = dtRented.Value;
                var dateReturned = dtReturned.Value;
                string carType = cboxTypeCar.Text;
                
                isValid = true;

                if (string.IsNullOrWhiteSpace(CustomerName) || string.IsNullOrWhiteSpace(cboxTypeCar.Text))
                {
                    MessageBox.Show("There are invalid data or check the empty boxes...");
                    isValid = false;
                }

                if(dateReturned < dateRented)
                {
                    MessageBox.Show("ERROR: Illegal date selection");
                    isValid = false;
                }


                if (isValid)
                {
                    var carRentalRecord = new CarRentalRecord();
                    carRentalRecord.id = 0;
                    carRentalRecord.CustomerName = CustomerName;
                    carRentalRecord.Cost = (decimal)Cost;
                    carRentalRecord.DateRented = dateRented;
                    carRentalRecord.DateReturned = dateReturned;
                    carRentalRecord.TypeOfCar = (int)cboxTypeCar.SelectedValue;

                    carRentalEntities.CarRentalRecords.Add(carRentalRecord);
                    carRentalEntities.SaveChanges();

                    MessageBox.Show("Already, it's was insert sucessfully...");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.InnerException.Message, "Upp.. a error here!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var car = carRentalEntities.TypeOfCars.ToList();
            cboxTypeCar.DisplayMember = "Name";
            cboxTypeCar.ValueMember = "id";
            cboxTypeCar.DataSource = car;
        }
    }
}
