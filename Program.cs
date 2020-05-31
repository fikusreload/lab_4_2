using System;

namespace labOOP
{
    class Runtime
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            SetStudentData(student);
            GetStudentData(student);
        }
        private static void SetStudentData(Student student)
        {
            Console.WriteLine("Name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Group: ");
            student.Group = Console.ReadLine();
            Console.WriteLine("Univercity entry year: ");
            student.Year = short.Parse(Console.ReadLine());
            Console.WriteLine("Address: ");
            student.Address = Console.ReadLine();
            Console.WriteLine("Passport serial number: ");
            student.Passport = Console.ReadLine();
            Console.WriteLine("Age: ");
            student.Age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Phone number: ");
            student.Telephone = Console.ReadLine();
            Console.WriteLine("Study Rating: ");
            student.Rating = byte.Parse(Console.ReadLine());
        }
        private static void GetStudentData(Student student)
        {
            Console.WriteLine("Name: {0}", student.Name);
            Console.WriteLine("Last Name: {0}", student.LastName);
            Console.WriteLine("Group: {0}", student.Group);
            Console.WriteLine("Univercity entry year: {0}", student.Year.ToString());
            Console.WriteLine("Address: {0}", student.Address);
            Console.WriteLine("Passport serial number: {0}", student.Passport);
            Console.WriteLine("Age: {0}", student.Age.ToString());
            Console.WriteLine("Phone number: {0}", student.Telephone);
            Console.WriteLine("Study Rating: {0}", student.Rating.ToString());
            if(student.Rating>90)
            {
                Console.WriteLine("Congratulations good student");
            }
            else if(student.Rating>75)
            {
                Console.WriteLine("You can study better");
            }
            else
            {
                Console.WriteLine("You should pay more attention to your studies");
            }
        }
    }
    class Student
    {
        private String name, lastName, group, address, passport, telephone;
        private byte age, rating;
        private short year;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public String Group
        {
            get { return group; }
            set { group = value; }
        }
        public short Year
        {
            get { return year; }
            set { year = value; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        public String Passport
        {
            get { return passport; }
            set { passport = value; }
        }
        public byte Age
        {
            get { return age; }
            set { age = value; }
        }
        public String Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public byte Rating
        {
            get { return rating; }
            set{ rating = value; }
        }
    }
}