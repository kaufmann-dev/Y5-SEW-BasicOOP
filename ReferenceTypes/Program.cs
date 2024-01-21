using ReferenceTypes;

Console.WriteLine("Erstelle ein neues Objekt des Typs 'Person'");
Person person1 = new Person("Max", "Mustermann");
Console.WriteLine("- Person 1: {0}", person1.GetFullName());

Console.WriteLine("Erstelle eine neue Referenz auf das Objekt 'person1'");
Person person2 = person1;
Console.WriteLine($"- Person 2: {person2.GetFullName()}");

Console.WriteLine("Ändere den Vornamen von 'person2'");
person2.FirstName = "John";
Console.WriteLine("- Person 1: {0}", person1.GetFullName());
Console.WriteLine("- Person 2: {0}", person2.GetFullName());

Console.WriteLine("Ändere den Vornamen von 'person1'");
person2.FirstName = "Hans";
Console.WriteLine("- Person 1: {0}", person1.GetFullName());
Console.WriteLine("- Person 2: {0}", person2.GetFullName());

Console.WriteLine("Erstelle ein neues Objekt des Typs 'Person'");
Person person3 = new Person("Anna", "Müller");
Console.WriteLine("- Person 3: {0}", person3.GetFullName());

Console.WriteLine("Setze 'person2' auf 'person3'");
person2 = person3;
Console.WriteLine("- Person 2: {0}", person2.GetFullName());
Console.WriteLine("- Person 3: {0}", person3.GetFullName());
    
Console.WriteLine("Setze 'person3' auf 'person1'");
person3 = person1;
Console.WriteLine("- Person 2: {0}", person2.GetFullName());
Console.WriteLine("- Person 3: {0}", person3.GetFullName());

Console.ReadLine();