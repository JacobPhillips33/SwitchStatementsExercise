Console.WriteLine("What is your favorite subject in school?");
var favSubject = Console.ReadLine();

switch (favSubject.ToLower())
{     
    case "math":
    case "calculus":
    case "geometry":
    case "algebra":
    case "trigonometry":
        Console.WriteLine("Math is my favorite too!");
        break;
    case "english":
    case "spanish":
    case "french":
        Console.WriteLine("Languages are cool.");
        break;
    case "science":
    case "physics":
    case "chemistry":
        Console.WriteLine("Science is fun!");
        break;
    case "history":
        Console.WriteLine("History is facinating.");
        break;
    case "pe":
    case "gym":
        Console.WriteLine("Who doesn't love gym class?!");
        break;
    default:
        Console.WriteLine($"I don't have a witty saying for {favSubject}.");
        break;
}
