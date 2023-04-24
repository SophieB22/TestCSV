namespace TestCSV
{
    internal class Program
    {

        static Passenger[] myPassenger = new Passenger[399];
        static void Main(string[] args)
        {
            String filePath = @"C:\Users\sophi\OneDrive - Atlantic TU\MyPrograms\faminefiletoanalyse.csv";
            try
            {

                StreamReader sr= new StreamReader(filePath);

                string recordIn = sr.ReadLine();        //read first line to file
                string[] fields = null;

                int sum = 0;
                int count = 0;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        fields = line.Split(',');  // split where there is a comma
                        Console.WriteLine(line);

                        if(fields.Length ==3)
                        {
                            myPassenger[count] = new Passenger();
                            myPassenger[count].firstName = fields[0];
                            myPassenger[count].lastName = fields[1];

                            int age = 0;
                            myPassenger[count].age = age;
                            if (fields[2].StartsWith("I"))  //Infant
                                age = 0;
                            if (fields[2].StartsWith("age"))
                                age = int.Parse(fields[2].Substring(4, 2));  //Take out 4 charac, leave in 2(age)
                            if (fields[2].StartsWith("U"))   //Unknown age
                                age = -1;
                            myPassenger[count].sex = fields[3];
                            myPassenger[count].occupation = fields[4];
                            myPassenger[count].nativeCountry = fields[5];
                            myPassenger[count].destination = fields[6];
                            myPassenger[count].embarked = fields[7];
                            myPassenger[count].chipID = fields[8];
                            myPassenger[count].arrivalDate = fields[9];

                            count++;
                        }
                        recordIn = sr.ReadLine();  //read the next record

                    }
                    sr.Close();


                    for(int i= 0; i < count; i++)
                    {
                        Console.WriteLine(myPassenger[i].lastName);
                    }
                }
            }
            catch(IOException myError)
            {
                Console.WriteLine(myError.Message);
            }
           catch(Exception myError)
            {
                Console.WriteLine("there was a problem");
            }

            // Main Menu

            Console.WriteLine(" Main Menu ");
            Console.WriteLine(" 1. Ship Reports ");
            Console.WriteLine(" 2. Occupation Reports ");
            Console.WriteLine(" 3. Age Reports ");
            Console.WriteLine(" 4. Exit ");
            Console.Write(" \nEnter Choice : ");

            int menuChoice = int.Parse(Console.ReadLine());

            while (menuChoice != 4)
            {
                if (menuChoice == 1)
                {
                    Console.WriteLine("Option 1 Selected ");
                }

                else if (menuChoice == 2)
                {
                    Console.WriteLine(" Option 2 Selected ");
                }
                else if (menuChoice == 3)
                {
                    Console.WriteLine(" Option 3 Selected");
                }
                else
                    Console.WriteLine(" Invalid Choice ");
            }
        }
            
    }
}