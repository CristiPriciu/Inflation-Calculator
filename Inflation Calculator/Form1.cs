using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inflation_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            PopulateDdlCountry();

    }

        List<CountryList> lstCountry = new List<CountryList>();
        private void PopulateDdlCountry()
        {
            lstCountry = new CountryList().GetAll();
            ddlCountry.DisplayMember = "Country";
            ddlCountry.ValueMember = "Country";
            ddlCountry.DataSource = lstCountry;
        }

        private void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = ddlCountry.SelectedValue.ToString();
            List<int> lstYearsS = new CountryList().GetYearsByCountry(selectedCountry);
            List<int> lstYearsE = new CountryList().GetYearsByCountry(selectedCountry);
            ddlStartYear.DataSource = lstYearsS;
            ddlEndYear.DataSource = lstYearsE;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm adminArea = new AdminForm();
            adminArea.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCountry = ddlCountry.SelectedValue.ToString();
                int startYear = Convert.ToInt32(ddlStartYear.SelectedValue);
                int endYear = Convert.ToInt32(ddlEndYear.SelectedValue);
                double inputValue = Convert.ToDouble(txtInput.Text);
                List<double> percentagesInput = new List<double>();
                DataTable dt = new DataTable();
                CountryList cnt = new CountryList();
                percentagesInput=cnt.GetPercetagesByCountry(selectedCountry, startYear, endYear).ToList();
                double temporarValue=inputValue;
                foreach (double d in percentagesInput)
                {
                    temporarValue +=temporarValue * (d * 0.01);
                }
                txtResult.Text = temporarValue.ToString("F2");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
