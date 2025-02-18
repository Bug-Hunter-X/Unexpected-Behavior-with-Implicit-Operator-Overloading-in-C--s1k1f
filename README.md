# Unexpected Behavior with Implicit Operator Overloading in C#

This example demonstrates a potential pitfall when using implicit operator overloading in C#. While convenient, implicit conversions can lead to unexpected behavior and make debugging more complex.

The `MyClass` class overloads both implicit conversion operators (from `int` to `MyClass` and vice versa).  This allows for adding integers directly to `MyClass` objects, but it may not always behave as expected. The implicit conversion might not be obvious when reading the code, which might lead to confusion. 

The `bug.cs` file contains code that showcases this unexpected behavior, while `bugSolution.cs` offers a more cautious approach.