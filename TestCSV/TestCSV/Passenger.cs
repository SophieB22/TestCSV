using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSV
{
    internal class Passenger
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string occupation { get; set; }
        public string nativeCountry { get; set; }
        public string destination { get; set; }
        public string embarked { get; set; }
        public string chipID { get; set; }
        public string arrivalDate { get; set; }


        public Passenger()
        {

        }

        public Passenger(string firstName)
        {
            this.firstName = firstName;
        }
        public string Name
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string Last
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        public string Occupation
        {
            get { return this.occupation; }
            set { this.occupation = value; }
        }

        public string Nativecountry
        {
            get { return this.nativeCountry; }
            set { this.nativeCountry= value; }
        }

        public string Destination
        {
            get { return this.destination; }
            set { this.destination = value; }
        }

        public string Embarked
        {
            get { return this.embarked; }
            set { this.embarked = value; }
        }

        public string ChipID
        {
            get { return this.chipID; }
            set { this.chipID = value; }
        }

        public string ArrivalDate
        {
            get { return this.arrivalDate; }
            set { this.arrivalDate = value; }
        }
    }

    
}
