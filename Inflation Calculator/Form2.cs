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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            PopulateDdlCountryInput();
        }

        List<CountryList> lstCountry = new List<CountryList>();
        private void PopulateDdlCountryInput()
        {
            lstCountry = new CountryList().GetAll();
            ddlCountryInput.DisplayMember = "Country";
            ddlCountryInput.ValueMember = "Country";
            ddlCountryInput.DataSource = lstCountry;
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            try
            {
                CountryList cl = new CountryList();
                cl.Country = Convert.ToString(ddlCountryInput.SelectedValue);
                cl.Year = Convert.ToInt32(txtYearInput.Text);
                double percentage = 0;
                bool parseToDouble = Double.TryParse(txtPercentageInput.Text, out percentage);
                if (!parseToDouble)
                {
                    MessageBox.Show("Valoarea procentaj trebuie sa fie numerica!");
                    return;
                }
                cl.Percentage = percentage;
                cl.Save("insert", cl);
                txtYearInput.Clear();
                txtPercentageInput.Clear();
                MessageBox.Show("Value added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
