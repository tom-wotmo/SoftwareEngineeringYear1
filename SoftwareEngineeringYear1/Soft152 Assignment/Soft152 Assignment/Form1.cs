using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Soft152_Assignment
{
    public partial class mainForm : Form
    {
        public static int selectedDistrict = 0;
        public static int selectedNeighbourhood = 0;
        public static int selectedProperty = 0;
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getDistricts();

            showDistricts();
     
        }

        private void showDistricts()
        {
            //clearing the items so that everytime this function is performed it doesn't duplicate the districts
            lstDistricts.Items.Clear();
   
            //for every district in the data.all districts 
            foreach (District d in Data.allDistricts)
            {
                //calling our getdistrictdata which has our string format 
                string output = d.getDistrictData();

                lstDistricts.Items.Add(output);
            
            }
          
        }

        private void showNeighbourhoods()
        {
            //clears the items in the listbox so when you call the function the data isn't duplicated
            lstNeighbourhoods.Items.Clear();
            
            //giving the thisneighbourhood variable some data, accessing our data.alldistricts array and selecting the one we've selected on our console. Then calling the GETNEIGHBOURHOOD method which has neighbourhood arrays in
            Neighbourhood[] thisNeighbourhood = Data.allDistricts[selectedDistrict].getNeighbourhood();
           
            //foreach of the neighbourhoods in the variable, so for each of the neighbourhoods in the selected index we are going to paste the output in the neighbourhood class.
            foreach (Neighbourhood n in thisNeighbourhood)
            {
                //calling our getdistrictdata which has our string format
                string output = n.getNeighbourhoodData();

                lstNeighbourhoods.Items.Add(output);
            }
           
        }


        private void showProperties()
        {
            lstProperties.Items.Clear();
            //getting the selected district
            District whichDistrict = Data.allDistricts[selectedDistrict];
            //getting the selected neighbourhoods of our selected district
            Neighbourhood whichNeighbourhood = whichDistrict.getNeighbourhood()[selectedNeighbourhood];
            
            //then outputting every property inside that selected neighbourhood
            foreach(Property p in whichNeighbourhood.getProperties())
            {
                string output = p.getPropertyData();

                lstProperties.Items.Add(output);

            }

        }
        
        private void ClearDistricts()
        {
            //setting the values of all the text boxes to nothing
            txtDistrictName.Text = "";
            txtNumberOfNeighbourhoods.Text = "";
         
        }
        private void ClearNeighbourhoods()
        {
            //setting the values of all the text boxes to nothing
            txtNeighbourhoodName.Text = "";
            txtNoOfNeighbourhoods.Text = "";
        }
        private void ClearProperties()
        {
            //setting the values of all the text boxes to nothing
            txtPropertyID.Text = "";
            txtPropertyName.Text = "";
            txtHostID.Text = "";
            txtHostName.Text = "";
            txtHostProperties.Text = "";
            txtLatitude.Text = "";
            txtLongitude.Text = "";
            txtRoomType.Text = "";
            txtPrice.Text = "";
            txtMinimumNights.Text = "";
            txtAvailability.Text = "";
        }

        private Property[] getProperties(int inputNumberOfProperties, StreamReader streamInput)
        {

            Property[] tempProperties = new Property[0];

            for (int i = 0; i < inputNumberOfProperties; i++)
            {
                //reading the last lines of the file and doing this x amount of times corresponding to the 
                string propertyID = streamInput.ReadLine();
                string propertyName = streamInput.ReadLine();
                string hostID = streamInput.ReadLine();
                string hostName = streamInput.ReadLine();
                string hostProperties = streamInput.ReadLine();
                string latitude = streamInput.ReadLine();
                string longitude = streamInput.ReadLine();
                string roomType = streamInput.ReadLine();
                int price = Convert.ToInt32(streamInput.ReadLine());
                int minNights = Convert.ToInt32(streamInput.ReadLine());
                int availability = Convert.ToInt32(streamInput.ReadLine());

                //re-sizing array
                Array.Resize(ref tempProperties, tempProperties.Length + 1);
                //reducing the length by one as we are going to store this into the neighbourhoods array and then into districts
                tempProperties[tempProperties.Length - 1] = new Property(propertyID, propertyName, hostID, hostName, hostProperties, latitude, longitude, roomType, price, minNights, availability);

            }

            return tempProperties;

        }
        private Neighbourhood[] getNeighbourhoods(int inputNumberofNeighbourhoods, StreamReader input)
        {
            Property[] theseProprties;

            Neighbourhood[] tempNeighbourhood = new Neighbourhood[0];

            for (int i = 0; i < inputNumberofNeighbourhoods; i++)
            {
                //reading the THIRD AND FOURTH lines of the file
                string neighbourHoodName = input.ReadLine();
                int numberOfProperties = Convert.ToInt32(input.ReadLine());


                //giving our get properties some values, our input file has been passed down from our getDistricts method
                theseProprties = getProperties(numberOfProperties, input);

                Array.Resize(ref tempNeighbourhood, tempNeighbourhood.Length + 1);

                tempNeighbourhood[tempNeighbourhood.Length - 1] = new Neighbourhood(neighbourHoodName, numberOfProperties, theseProprties);

            }

            return tempNeighbourhood;

        }

        private void getDistricts()
        {
            Neighbourhood[] theseNeighbourhoods;

            StreamReader inputFile = new StreamReader("minifile.txt");
            while (!inputFile.EndOfStream)
            {
                //Reading the first TWO lines of the file
                string districtName = inputFile.ReadLine();
                int numberOfNeighbourHoods = Convert.ToInt32(inputFile.ReadLine());

                //giving the method getNeighbourhoods some parameters so it knows how many times to read and what file to read from
                theseNeighbourhoods = getNeighbourhoods(numberOfNeighbourHoods, inputFile);

                                                    //string          //integer       //Array of NEIGHBOURHOODS     
                District newDistrict = new District(districtName, numberOfNeighbourHoods, theseNeighbourhoods);

                //acccessing our data class and storing our data inside the array
                int oldArraySize = Data.allDistricts.Length;
                Array.Resize(ref Data.allDistricts, oldArraySize + 1);

                //resized our array
                Data.allDistricts[oldArraySize] = newDistrict;

            }

            inputFile.Close();
        }

        private void lstDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //giving values to the current selected district and setting it to "selectedDistrict"
            selectedDistrict = lstDistricts.SelectedIndex;
            showNeighbourhoods();
            District thisDistrict = Data.allDistricts[selectedDistrict];
            //giving the txt boxes data dependent on which District has been selected it will get access our getters and fill in the boxes
            txtDistrictName.Text = thisDistrict.getDistrictName();
            txtNumberOfNeighbourhoods.Text = Convert.ToString(thisDistrict.getNumberofneighbourhood());

        }

        private void lstNeighbourhoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            //giving values to the current selected district and setting it to "selectedNeighbourhood"
            selectedNeighbourhood = lstNeighbourhoods.SelectedIndex;
            showProperties();
            District thisDistrict = Data.allDistricts[selectedDistrict];
            Neighbourhood thisNeighbourhood = thisDistrict.getNeighbourhood()[selectedNeighbourhood];
            //giving the txt boxes data dependent on which Neighbourhood has been selected it will get access our getters and fill in the boxes
            txtNeighbourhoodName.Text = thisNeighbourhood.getneighbourhoodName();
            txtNoOfNeighbourhoods.Text = Convert.ToString(thisNeighbourhood.getnumberofProperties());


        }
        private void lstProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            //giving a variable to your selected index
            selectedProperty = lstProperties.SelectedIndex;
            //passing down the arrays
            District thisDistrict = Data.allDistricts[selectedDistrict];
            //accessing the neighourhood array to get our neighbourhood
            Neighbourhood thisNeighbourhood = thisDistrict.getNeighbourhood()[selectedNeighbourhood];
            //accessing the property array to get our property's and getting the selected one of that
            Property thisProperty = thisNeighbourhood.getProperties()[selectedProperty];
            //giving the txt boxes data dependent on which property has been selected it will get access our getters and fill in the boxes
            txtPropertyID.Text = thisProperty.getPropertyId();
            txtPropertyName.Text = thisProperty.getPropertyName();
            txtHostID.Text = thisProperty.getHostId();
            txtHostName.Text = thisProperty.getHostName();
            txtHostProperties.Text = thisProperty.getHostProperties();
            txtLatitude.Text = thisProperty.getLatitude();
            txtLongitude.Text = thisProperty.getLongitude();
            txtRoomType.Text = thisProperty.getRoomType();
            txtPrice.Text = Convert.ToString(thisProperty.getPrice());
            txtMinimumNights.Text = Convert.ToString(thisProperty.getMinNight());
            txtAvailability.Text = Convert.ToString(thisProperty.getAvailability());

        }

        private void btnDistrictEdit_Click(object sender, EventArgs e)
        {
            //get the variables from a string input
            string edDistrictName = txtDistrictName.Text;
            int edNoOfNeighbourhoods = Convert.ToInt32(txtNoOfNeighbourhoods.Text);
          
            Neighbourhood[] editedNeighbourhood = new Neighbourhood[0];

            //create a new district array
            District editedDistrict = new District(edDistrictName, edNoOfNeighbourhoods, editedNeighbourhood);

            //replace it with the district array i have selected.
            Data.allDistricts[selectedDistrict] = editedDistrict;

            showDistricts();

        }
        private void btnNeighbourhoodEdit_Click(object sender, EventArgs e)
        {
            string edNeighbourhoodName = txtNeighbourhoodName.Text;
            int edNoOfProps = Convert.ToInt32(txtNoOfNeighbourhoods.Text);
            Property[] editedProperty = new Property[0];

            Neighbourhood editedNeighbourhood = new Neighbourhood(edNeighbourhoodName, edNoOfProps, editedProperty);

            District thisDistrict = Data.allDistricts[selectedDistrict];

            editedNeighbourhood = thisDistrict.getNeighbourhood()[selectedNeighbourhood];

            showNeighbourhoods();

        }


        private void btnDistrictAdd_Click(object sender, EventArgs e)
        {
            //store variables for the txt box's input
            string _districtName = txtDistrictName.Text;
            int _noOfNeighbourhoods = Convert.ToInt32(txtNumberOfNeighbourhoods.Text);
            Neighbourhood[] neighbourhoodArray = new Neighbourhood[0];
            //create a temporary district array
            District temp = new District(_districtName, _noOfNeighbourhoods,neighbourhoodArray);
            //get the current length of the district array and increase it by 1
            int newDistrict = Data.allDistricts.Length;

            Array.Resize(ref Data.allDistricts, newDistrict + 1);
            //apply the new size to the array 
            Data.allDistricts[newDistrict] = temp;

            MessageBox.Show("Added new District.");

            showDistricts();

        }
        private void btnNeighbourhoodAdd_Click(object sender, EventArgs e)
        {
           
            //storing varibales for the txt box's input
            string _neighbourhoodName = txtNeighbourhoodName.Text;
            int _noOfProperties = Convert.ToInt32(txtNoOfNeighbourhoods.Text);
            Property[] propertyArray = new Property[0];
            //creating a temporary neighbourhood array
            Neighbourhood neighb = new Neighbourhood(_neighbourhoodName, _noOfProperties,propertyArray);


            //get NBHood ARRAY the right array first       
            Neighbourhood[] allNBHoods = Data.allDistricts[selectedDistrict].getNeighbourhood();

            //Add to LOCAL array
            int originalNBHood = allNBHoods.Length;
            Array.Resize(ref allNBHoods, originalNBHood + 1);
            allNBHoods[originalNBHood] = neighb;


            //UPDATE main array in the data class
            Data.allDistricts[selectedDistrict].setallNBHoods(allNBHoods);
            Data.allDistricts[selectedDistrict].setNumberofneighbourhood(originalNBHood + 1);

            MessageBox.Show("Added new Neighbourhood.");

            showNeighbourhoods();
            showDistricts();

        }
        private void BtnPropertiesAdd_Click(object sender, EventArgs e)
        {
            //storing variables for the box's input
            string _propertyID = txtPropertyID.Text;
            string _propertyName = txtPropertyName.Text;
            string _hostId = txtHostID.Text;
            string _hostName = txtHostName.Text;
            string _hostProperties = txtHostProperties.Text;
            string _latitude = txtLatitude.Text;
            string _longitude = txtLongitude.Text;
            string _roomType = txtRoomType.Text;
            int _price = Convert.ToInt32(txtPrice.Text);
            int _minimumNight = Convert.ToInt32(txtMinimumNights.Text);
            int _availability = Convert.ToInt32(txtAvailability.Text);

            //creating a temporary property array
            Property prop = new Property(_propertyID, _propertyName, _hostId, _hostName, _hostProperties, _latitude, _longitude, _roomType, _price, _minimumNight, _availability);

            //getting the correct district
            District thisDistrict = Data.allDistricts[selectedDistrict];
            //using the district to get the correct neighbourhood
            Neighbourhood thisNeighbourhood = thisDistrict.getNeighbourhood()[selectedNeighbourhood];
            //using our neighbourhood to retrieve our propertys and the length of that
            Property[] theseProperties = thisNeighbourhood.getProperties();

            //giving the originalproperty a length
            int originalProperty = theseProperties.Length;
            //resizing the array and adding one to it
            Array.Resize(ref theseProperties, originalProperty + 1);

            //put prop into local array
            theseProperties[originalProperty] = prop;

            thisNeighbourhood.setProperties(theseProperties);
            thisNeighbourhood.setnumberofProperties(originalProperty + 1);

            MessageBox.Show("Added new Property.");

            showProperties();
            showNeighbourhoods();
        }

        private void btnDistrictClear_Click(object sender, EventArgs e)
        {
            //calling the clear districts method everytime the button is pressed
            ClearDistricts();
        }

        private void btnNeighbourhoodClear_Click(object sender, EventArgs e)
        {
            //calling the clear neighbourhoods method everytime the button is pressed
            ClearNeighbourhoods();
        }

        private void btnPropertyClear_Click(object sender, EventArgs e)
        {
            //calling the clear properties method everytime the button is pressed
            ClearProperties();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            //exit the current application
            Application.Exit();
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }



























        //private void getProperty()
        //{
        //    StreamReader inputFile = new StreamReader("minifile.txt");

        //    Property[] tempProperty = new Property[0];

        //    string propertyID = inputFile.ReadLine();
        //    string propertyName = inputFile.ReadLine();
        //    string hostID = inputFile.ReadLine();
        //    string hostName = inputFile.ReadLine();
        //    string hostProperties = inputFile.ReadLine();
        //    string latitude = inputFile.ReadLine();
        //    string longitude = inputFile.ReadLine();
        //    string roomType = inputFile.ReadLine();
        //    int price = Convert.ToInt32(inputFile.ReadLine());
        //    int minNights = Convert.ToInt32(inputFile.ReadLine());
        //    int availability = Convert.ToInt32(inputFile.ReadLine());

        //    Array.Resize(ref tempProperty, tempProperty.Length + 1);

        //    tempProperty[tempProperty.Length - 1] = new Property(propertyID, propertyName, hostID, hostName, hostProperties, latitude, longitude, roomType, price, minNights, availability);
        //}

        //private void getNeighbourhood()
        //{
        //    StreamReader inputFile = new StreamReader("minifile.txt");

        //    string neighbourhoodName = inputFile.ReadLine();
        //    int numberOfProperties = Convert.ToInt32(inputFile.ReadLine());



        //}

    }
}
