using System;

class Program
{
     public class Patient
    {
        // properties
        public string Name;
        public double Height;
        public double Weight;
        public DateTime BirthDate = new DateTime();
        //  constructor 
        public Patient(string name,double height, double weight,DateTime birthdate)
        {
            Name = name;
            Height = height;
            Weight = weight; 
            BirthDate = birthdate; 
        }
        // methods

        public void Age()
        {
            Console.WriteLine($"{BirthDate.Year}");
        }
        public void PatientDetails()
{
    Console.WriteLine($"{Name}, Height: {Height}, Weight: {Weight}, Birthdate: {BirthDate:d}");
}
    
    };
    static void Main(string[] args)
    {
        Patient outpatient  = new Patient("Patient 1",1.7,55.4,new DateTime(1990,01,02));
        outpatient.PatientDetails();
        outpatient.Age();
    }
}
    
   
