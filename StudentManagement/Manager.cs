public class Manager
{
    public void PrintDetails(Person person)
    {
        person.DisplayInfo();  // Calls method based on actual object type (runtime polymorphism)
    }
}
