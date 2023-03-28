# Projects
## Arnautica
This project is about interfaces, builders and factories.
## Creatures
This project is about inheritance.
## DataStructure
This project is about linked lists and binary trees.
## Geometry
This project is about tuples, points and vectors.
## ReferenceTypes
This projects explains reference types in C#.
# Access modifiers
## public
```
public int age = 25;
```
The type or member can be accessed by any other code in the same assembly or another assembly that references it. The accessibility level of public members of a type is controlled by the accessibility level of the type itself.
## private
```
private string name = "John";
```
The type or member can be accessed only by code in the same class or struct.
## protected
```
protected decimal salary = 5000.00M;
```
The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
## internal
```
internal bool isEmployee = true;
```
The type or member can be accessed by any code in the same assembly, but not from another assembly. In other words, internal types or members can be accessed from code that is part of the same compilation.
## protected internal
```
protected internal string address = "123 Main St.";
```
The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.
## private protected
```
private protected DateTime hireDate = new DateTime(2020, 01, 01);
```
The type or member can be accessed by types derived from the class that are declared within its containing assembly.
# Constant fields
```
public const string Name = "Name";
```
- Evaluated at compile time instead of runtime
- Saved in assembly
- Must be provided with a value
# Property accessors
## get accessor
```
public int MyProperty { get { return myField; } }
```
Used to retrieve the value of a property.
## set accessor
```
public int MyProperty { set { myField = value; } }
```
Used to allow a property to be set only within the same assembly or in derived classes.
## private set accessor
```
public int MyProperty { get; private set; }
```
Used to allow a property to be set only within the same class.
## protected set accessor
```
public int MyProperty { get; protected set; }
```
Used to allow a property to be set only within the same class or in derived classes.
## internal set accessor
```
public int MyProperty { get; internal set; }
```
Used to allow a property to be set only within the same assembly.
## protected internal set accessor
```
public int MyProperty { get; protected internal set; }
```
Used to allow a property to be set only within the same assembly or in derived classes.
## private protected set
```
public int MyProperty { get; private protected set; }
```
Used to allow a property to be set only by types derived from the class that are declared within its containing assembly.
## init accessor
```
public int MyProperty { get; init; }
```
Used for initializing the value of a property for object initialization. An init property can be set only within an object initializer or a constructor.
## Indexer accessors
```
public int this[int index] { get { return myArray[index]; } set { myArray[index] = value; } }
```
Used to add or remove event handlers to an event. There are two types of event accessors: add and remove. The add accessor adds an event handler to an event, while the remove accessor removes an event handler from an event.
## Event accessors
```
public event EventHandler MyEvent { add { myEventHandlers.Add(value); } remove { myEventHandlers.Remove(value); } }
```
Used to add or remove event handlers to an event. There are two types of event accessors: add and remove. The add accessor adds an event handler to an event, while the remove accessor removes an event handler from an event.