string? num1 = "";
string? num2 = "";
var sum = num1 + num2;
string? myString = "";
string? sentenceText = "Lorem ipsum is placeholder text commonly used in the graphic, print, and publishing industries for previewing layouts and ";

Console.Write("Enter 2 Numbers: ");
Console.ReadLine();
int num1 = int.Parse(Console.ReadLine()?? "0");
num2 = Console.ReadLine();


Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum + ".");


Console.Write("Type a word here: ");
Console.ReadLine();
myString= Console.ReadLine();
Console.WriteLine("Word typed: " + myString.ToUpper());

bool trueVar = true;
bool falseVar = false;

// using logical NOT operator on the variables
Console.WriteLine(!trueVar);
Console.WriteLine(!falseVar);
