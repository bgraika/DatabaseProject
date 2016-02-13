using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YelpDatabaseProject
{
    public partial class Form1 : Form
    {
        MySQL_connection mydb;
        public Form1()
        {
            InitializeComponent();
            mydb = new MySQL_connection();
        }

        //on dropdown all states in the database will appear
        private void state_dropDown_DropDown(object sender, EventArgs e)
        {
            //must make a list of strings that just holds state because all
            //we're looking for is state
            List<string> stateColumn = new List<string>();
            stateColumn.Add("state");

            string qStr = "SELECT distinct state FROM CensusData ORDER BY state;";
            List<List<string>> qResult = mydb.SQLSELECTExec(qStr, stateColumn);

            //copy query results to the dropdown
            for (int i = 0; i < qResult[0].Count(); i++)
            {
                state_dropDown.Items.Add(qResult[0][i]);
            }
        }

        //when a state is selected, display the cities in the city listbox
        private void state_dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //add city to the columns to look for
            List<string> cityColumn = new List<string>();
            cityColumn.Add("city");

            string selected_state = state_dropDown.SelectedItem.ToString(); //the selected state
            string qStr = "SELECT city FROM CensusData WHERE state= '"+ selected_state + "' ORDER BY city;";
            List<List<string>> qResult = mydb.SQLSELECTExec(qStr, cityColumn);

            //copy query results to the listbox
            for (int i = 0; i < qResult[0].Count(); i++)
            {
                city_listbox.Items.Add(qResult[0][i]);
            }
        }

        //when a city is selected display the zipcodes within that city in the zipcode listbox
        private void city_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //add zipcode to the columns to look for
            List<string> cityColumn = new List<string>();
            cityColumn.Add("zipcode");

            string selected_city = city_listbox.SelectedItem.ToString(); //the selected state
            string qStr = "SELECT zipcode FROM CensusData WHERE city= '" + selected_city + "' ORDER BY zipcode;";
            List<List<string>> qResult = mydb.SQLSELECTExec(qStr, cityColumn);

            //copy query results to the listbox
            for (int i = 0; i < qResult[0].Count(); i++)
            {
                zipcode_listbox.Items.Add(qResult[0][i]);
            }
        }

    }
}
