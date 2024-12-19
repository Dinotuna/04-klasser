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

    public int SetWage()
    {
        return wage;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public int GetWage()
    {
        return wage;
    }

}

