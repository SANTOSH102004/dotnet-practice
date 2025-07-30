class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.SetName("Santosh");
        s1.SetAge(21);
        s1.RollNo = 101;

        Teacher t1 = new Teacher();
        t1.SetName("Mr. Sharma");
        t1.SetAge(40);
        t1.Subject = "Math";

        Manager m = new Manager();

        Console.WriteLine("----Details----");
        m.PrintDetails(s1);  // Runtime Polymorphism
        m.PrintDetails(t1);

        // Demonstrate Method Overloading
        s1.SubmitAssignment();
        s1.SubmitAssignment("JAVA");
    }
}
