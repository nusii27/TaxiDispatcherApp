using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TaxiDispatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Taxi[] dispacher = { 
            new Taxi("CTC0001", "Nusi", "Toyota", "Camry", "black"), 
            new Taxi("CTC0002", "Christian","Ford", "Explorer", "blue"),
            new Taxi("CTC0003", "Nishi", "Nissan", "Ultima", "gray"),
            new Taxi("CTC0004", "Riri", "Toyota", "Corolla", "gold"),
            new Taxi("CTC0005", "Rafi", "Honda", "CRV", "red"),
            new Taxi("CTC0006", "Ria", "Tesla","ModelS","white")
            };

        //Store the passengers served for each taxi
        int[] driver_served = { 0, 0, 0, 0, 0, 0 };
        //Store the calls for each taxi
        int[] calls = { 0, 0, 0, 0, 0, 0 };

        private void btnRequest_Click(object sender, EventArgs e)
        {
            //Use random method to reach random dispacher
            Random random = new Random();
            //random range from 0 to total taxi class members
            int rand = random.Next(0, dispacher.Length);

            int passengers = dispacher[rand].getPassages();
            string taxi = dispacher[rand].getTaxiID();
            string driver = dispacher[rand].getDriver();
            string maker = dispacher[rand].getMaker();
            string model = dispacher[rand].getModel();
            string color = dispacher[rand].getColor();

            //call setServed function for add served passengers to total served.
            dispacher[rand].setServed(passengers);
            // call addcalls function for add calls to this instance.
            dispacher[rand].addCalls();
            //add served passengers and store to the array driver_served
            driver_served[rand] += passengers;

            txtTaxi.Text = "Taxi "+taxi+" a "+color+" "+maker+" "+model+" driven by "+driver+ " will pick you up in a few minutes. (Taxi "+taxi+ " determined that there were " + passengers.ToString()+" passengers)";
        }




        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dispacher.Length; i++)
            {

                calls[i] = dispacher[i].getCalls();

                
            }

            //get max served
            int max = driver_served.Max();

            //find max value index
            int max_car = Array.IndexOf(driver_served, max);
            Taxi total = new Taxi();
            //get total served value
            int totals = total.getServed();

            //get average served
            double avg = Decimal.ToDouble(totals) / 6;
            txtReport.Text = "CTC Taxi served a total of "+total.getServed()+" passengers today. \r\n" + dispacher[0].getTaxiID()+ 
                "      "+dispacher[1].getTaxiID() + "      " + dispacher[2].getTaxiID() + "      " + dispacher[3].getTaxiID() + "      " + dispacher[4].getTaxiID() + "      " +
                dispacher[5].getTaxiID() + "\r\n" + calls[0]+" Calls          "+ calls[1] + " Calls             " + calls[2] + " Calls            " + calls[3] + " Calls           " + calls[4] + " Calls            " + calls[5] + " Calls            " + "\r\n"
                + driver_served[0]+" Passengers   "+ driver_served[1] + " Passengers   " + driver_served[2] + " Passengers   " + driver_served[3] + " Passengers   " + driver_served[4] + " Passengers   " + driver_served[5] + " Passengers   \r\n"+
                "Today " + dispacher[max_car].getTaxiID() + " served most passengers.\r\n"+ "Today on average each taxi served "+Math.Round(avg,1)+" passengers."
                ;
        }

        private void txtTaxi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReport_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
