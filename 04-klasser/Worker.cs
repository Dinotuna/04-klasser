public class Worker
{
    protected string name;
    protected int age;
    protected int wage;

    public Worker()
    {
        name = "albin";
        age = 34;
        wage = 10;
    }

    public void SetWage(int newWage)
    {
        wage = newWage;
        Console.WriteLine(newWage);
    }

    public string GetName()
    {
        Console.WriteLine(name);
        return name;
    }

    public int GetAge()
    {
        Console.WriteLine(age);
        return age;
    }

    public int GetWage()
    {
        System.Console.WriteLine(wage);
        return wage;
    }

}

