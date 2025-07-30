public class Teacher : Person
{
    public string Subject { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Teacher: {GetName()}, Age: {GetAge()}, Subject: {Subject}");
    }
}
