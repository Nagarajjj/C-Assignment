using System;
using System.IO;


namespace Assignment
{
    class Patient
    {
        static int patientNo = 1000;
        public Patient()
        {
            PatientID = ++patientNo;
        }

        public Patient(int id)
        {
            PatientID = id;
        }
        public int PatientID { get; set; }
        public string Name { get; set; }
        public double PhoneNo { get; set; }
        public double BillAmount { get; set; }
        public override string ToString()
        {
            return $"{PatientID}, {Name}, {PhoneNo}, {BillAmount}";
        }
    }
    class Assign
    {
        const string fileName = "PatientDetails.csv";
        static void writeToFile(Patient emp)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine(emp);
            writer.Close();
            fs.Close();
        }



        static Patient readFromFile()
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs);
                string data = reader.ReadLine();
                string[] details = data.Split(',');
                Patient pat = new Patient(int.Parse(details[0]));
                pat.Name = details[1];
                pat.PhoneNo = double.Parse(details[2]);
                pat.BillAmount = double.Parse(details[3]);
                fs.Close();
                return pat;
            }
            throw new Exception("File does not exist");
        }



        static void writeUsingFile(Patient pat)
        {
            if (File.Exists(fileName))
            {
                File.WriteAllText(fileName, pat.ToString());
            }
        }
        static Patient readUsingFile()
        {
            if (File.Exists(fileName))
            {
                var lines = File.ReadLines(fileName);
                foreach (var line in lines)
                {
                    string[] details = line.Split(',');
                    Patient pat = new Patient(int.Parse(details[0]));
                    pat.Name = details[1];
                    pat.PhoneNo = double.Parse(details[2]);
                    pat.BillAmount = double.Parse(details[3]);
                    return pat;
                }
            }
            throw new Exception("File not found");
        }
        static void Main(string[] args)
        {
            writeToFile(new Patient { Name = "Nagaraj", PhoneNo = 7878787878, BillAmount = 9089 });
            Console.WriteLine(readFromFile());
            writeToFile(new Patient { Name = "Mrnags", PhoneNo = 9898989898, BillAmount = 10000 });
            Console.WriteLine(readFromFile());
            writeToFile(new Patient { Name = "kanasu", PhoneNo = 6342517112, BillAmount = 30000 });
            Console.WriteLine(readFromFile());
        }
    }
}