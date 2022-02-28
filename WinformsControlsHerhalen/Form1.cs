using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsControlsHerhalen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SeedCountry seedCountry = new SeedCountry();
            SeedPeople seedPeople = new SeedPeople();
            //var allPeople = SeedPeople.GetPeople();  
            IEnumerable<Person> allPeople = seedPeople.People;

            foreach (var item in allPeople)
            {
                lstAllPeople.Items.Add(item);
            }

            // lstAllPeople.DataSource = allPeople;  

            IEnumerable<Country> allCountries = seedCountry.Countries;
            foreach (var item in allCountries)
            {
                lstAllCountries.Items.Add(item);

            }

            IEnumerable<Country> allCountriesForComboBox = seedCountry.Countries;
            foreach (var item in allCountriesForComboBox)
            {
                cmbCountry.Items.Add(item);

            }
        }

        private void btnFilterByAge_Click(object sender, EventArgs e)
        {
            SeedPeople seedPeople = new SeedPeople();
            try
            {
                IEnumerable<Person> listPerAge = seedPeople.People.Where(x => x.Age == Convert.ToInt32(txtFilter.Text)).ToList();
                lstDemo.DataSource = listPerAge;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            //IEnumerable<Person> allPeople = SeedPeople.GetPeople();
            //foreach (var item in allPeople)
            //{
            //    if (item.Country==Convert.ToInt32(txtFilter.Text))
            //    {
            //        lstDemo.Items.Add(item);
            //    }
            //}
        }

        private void btnFilterByCountry_Click(object sender, EventArgs e)
        {
            SeedPeople seedPeople = new SeedPeople();
            try
            {

              IEnumerable<Person>list = seedPeople.People.Where(x => x.Country== Convert.ToInt32(txtFilter.Text)).ToList();
              lstDemo.DataSource = list;
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message);
                txtFilter.Focus();
            }
        }
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeedPeople seedPeople = new SeedPeople();
            // With Lambda

            //int selected = cmbCountry.SelectedIndex + 1;
            ////MessageBox.Show(selected.ToString());
            //IEnumerable<Person> list = SeedPeople.People.Where(x => x.Country == selected).ToList();
            //lstDemo.DataSource = list;

            lstDemo.Items.Clear();
            int selected = cmbCountry.SelectedIndex + 1;
            IEnumerable<Person> people = seedPeople.People;
            foreach (var person in people)
            {
                if (person.Country==selected)
                {
                    lstDemo.Items.Add(person);
                }
            }
        }
        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            SeedPeople seedPeople = new SeedPeople();
            var person = seedPeople.People.Find(x => x.Id == (Convert.ToInt32(txtFilter.Text)));
            lstDemo.Items.Add(person);
        }
    }
}
