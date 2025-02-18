//Consider making implicit conversions explicit to improve code readability and reduce unexpected behavior.
public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    //Making the operators explicit
    public static explicit operator int(MyClass myClass)
    {
        return myClass.MyProperty;
    }

    public static explicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 5; // Implicit conversion from int to MyClass
        int value1 = (int)obj1; // Explicit conversion from MyClass to int

        Console.WriteLine(obj1.MyProperty); // Output: 5
        Console.WriteLine(value1); // Output: 5

        MyClass obj2 = new MyClass(10);
        int value2 = (int)obj2 + 5; // Explicit conversion of obj2 to int and then addition

        Console.WriteLine(value2); // Output: 15

        MyClass obj3 = (MyClass)((int)obj2 + 1); // Explicit conversion to int, addition and explicit conversion back to MyClass
        Console.WriteLine(obj3.MyProperty); //Output 11
    }
} 