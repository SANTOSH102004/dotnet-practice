public abstract class Person
{
    private string name;
    private int age;

    public string GetName() => name;
    public void SetName(string n) => name = n;

    public int GetAge() => age;
    public void SetAge(int a) => age = a;

    public abstract void DisplayInfo();  // Abstract method
}
