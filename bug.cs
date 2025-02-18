public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass myClass)
    {
        return myClass.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 5; // Implicit conversion from int to MyClass
        int value1 = obj1; // Implicit conversion from MyClass to int

        Console.WriteLine(obj1.MyProperty); // Output: 5
        Console.WriteLine(value1); // Output: 5

        MyClass obj2 = new MyClass(10);
        int value2 = obj2 + 5; // Implicit conversion of obj2 to int and then addition

        Console.WriteLine(value2); // Output: 15

        MyClass obj3 = obj2 + 1; // Implicit conversion to int, addition and implicit conversion back to MyClass
        Console.WriteLine(obj3.MyProperty); //Output 11
    }
}