public class Student : Person
{
    public int RollNo { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student: {GetName()}, Age: {GetAge()}, Roll No: {RollNo}");
    }

    // Method Overloading (Compile-time Polymorphism)
    public void SubmitAssignment()
    {
        Console.WriteLine("Assignment submitted.");
    }

    public void SubmitAssignment(string subject)
    {
        Console.WriteLine($"Assignment submitted for {subject}.");
    }
}
