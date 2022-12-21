using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDispatcher
{
    public class Taxi
    {
        private string taxiId;
        private string driverName;
        private string carMaker;
        private string carModel;
        private string carColor;
        private int numofPass;
        static private int totalPass;
        private int taxiCalls = 0;



        public Taxi(string id, string name, string maker, string model, string color)
        {
            this.taxiId = id;
            this.driverName = name;
            this.carMaker = maker;
            this.carModel = model;
            this.carColor = color;

        }

        public Taxi(){}
        public int addCalls()
        {
            return taxiCalls++;
        }
        public int getPassages()
        {

            Random random = new Random();
            numofPass = random.Next(1, 4);
            return numofPass;

        }
        public int setServed(int total)
        {
            totalPass += total;
            return totalPass;
        }
        public int getServed()
       {

            return totalPass;
        }
        public string getTaxiID()
        {
            return taxiId;
        }
        public string getDriver()
        {
            return driverName;
        }
        public string getMaker()
        {
            return carMaker;
        }
        public string getModel()
        {
            return carModel;
        }
        public string getColor()
        {
            return carColor;
        }
        public int getCalls()
        {
            return taxiCalls;
        }
        


    
    }

   

}
