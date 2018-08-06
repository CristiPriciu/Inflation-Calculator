using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inflation_Calculator
{
    public class CountryList
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private double percentage;
        public double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }

        public List<CountryList> GetAll()
        {
            List<SqlDbParameter> paramCountry = new List<SqlDbParameter>();
            paramCountry.Add(new SqlDbParameter("act", "get"));
            DataTable dtCountry = new DataTable();
            DataAccess.RunSP("SpDdlCountry", paramCountry, ref dtCountry);

            List<CountryList> lstCountry = new List<CountryList>();
            foreach (DataRow row in dtCountry.Rows)
            {
                CountryList g = new CountryList();
                //g.ID = Convert.ToInt32(row["ID"]);
                g.Country = row["Country"].ToString();
                lstCountry.Add(g);
            }
            return lstCountry;
        }

        public List<int> GetYearsByCountry(string selectedCountry)
        {
            List<SqlDbParameter> paramCountry = new List<SqlDbParameter>();
            paramCountry.Add(new SqlDbParameter("act", "getYears"));
            paramCountry.Add(new SqlDbParameter("country", selectedCountry));
            DataTable dt = new DataTable();
            DataAccess.RunSP("SpDdlCountry", paramCountry, ref dt);

            List<int> lstYears = new List<int>();
            foreach (DataRow row in dt.Rows)
            {
                int year = Convert.ToInt32(row["Year"].ToString());
                lstYears.Add(year);
            }
            return lstYears;
        }

        public List<double> GetPercetagesByCountry(string selectedCountry, int startYear, int endYear)
        {
            List<SqlDbParameter> paramPercentages = new List<SqlDbParameter>();
            paramPercentages.Add(new SqlDbParameter("act", "getpercentagebyinterval"));
            paramPercentages.Add(new SqlDbParameter("country", selectedCountry));
            paramPercentages.Add(new SqlDbParameter("startYear", startYear));
            paramPercentages.Add(new SqlDbParameter("endYear", endYear));
            DataTable dt = new DataTable();
            DataAccess.RunSP("SpDdlCountry", paramPercentages, ref dt);

            List<double> lstPercentages = new List<double>();
            foreach (DataRow row in dt.Rows)
            {
                double perc = Convert.ToDouble(row["Percentage"]);
                lstPercentages.Add(perc);
            }
            return lstPercentages;
        }

        //Uploading function for Admin Area
        public void Save(string operation, CountryList current)
        {
            List<SqlDbParameter> param = new List<SqlDbParameter>();
            param.Add(new SqlDbParameter("@act", operation));

            SqlConnection con = new SqlConnection(DataAccess.ConnectionString);
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDdlCountry";
            cmd.Parameters.AddWithValue("@act", operation);
            cmd.Parameters.AddWithValue("@country", Country);
            cmd.Parameters.AddWithValue("@year", Year);
            cmd.Parameters.AddWithValue("@percentage", Percentage);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}
