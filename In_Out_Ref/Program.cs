

//class RefeClass
//{

//    static void Method(ref Person person)
//    {
//        person = new Person();
//        person.Name = "MAhdi";
//    }

//    static void Main()
//    {

//        var person = new Person
//        {
//            Name = "TestName",
//            Family="testFamily"
//        };


//        Method(ref person);
//        Console.WriteLine("Name:");
//        Console.WriteLine(person.Name);
//        Console.WriteLine("\nFamily:");
//        Console.WriteLine(person.Family);

//    }
//}



//class Out
//{
//    static void Method(out Person person)
//    {
//        //We need to initialize the variable in the method before we can do anything
//        person = new Person();
//        person.Name="Mahdi";
//    }

//    static void Main()
//    {
//        Person person;

//        Method(out person); 
//    }
//}

class In
{

    static void Method(in Person person)
    {
       
        person.Name = "MAhdi";
    }

    static void Main()
    {

        var person = new Person
        {
            Name = "TestName",
            Family = "testFamily"
        };


        Method(in person);
        Console.WriteLine("Name:");
        Console.WriteLine(person.Name);
        Console.WriteLine("\nFamily:");
        Console.WriteLine(person.Family);

    }
}

public class Person
{
    public string Name { get; set; }
    public string Family { get; set; }
}