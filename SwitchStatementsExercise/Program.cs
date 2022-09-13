Console.WriteLine("What is your favorite subject in school?");
var favSubject = Console.ReadLine();

switch (favSubject)
{
    case "Math":
        Console.WriteLine("Math is my favorite too!");
        break;
    case "English":
        Console.WriteLine("English is very important.");
        break;
    case "Science":
        Console.WriteLine("Science is cool.");
        break;
    case "History":
        Console.WriteLine("History is facinating.");
        break;
    case "PE":
        Console.WriteLine("PE is a popular choice for many.");
        break;
    default:
        Console.WriteLine($"{favSubject} is a unique choice.");
        break;
}
