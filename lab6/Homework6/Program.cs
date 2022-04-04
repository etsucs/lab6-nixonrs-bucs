/*Method 1: Show Character
Write a method named ShowCharacter. This method 
should accept two arguments: a reference to a string object, 
and an integer. The integer argument is a character position 
within the string, with the first character being 1. When the method 
executes, it should display the character at that position. (The position 
is a human position and not a computer science position.)
Example:
ShowCharacter(“New York”, 2);
//this would display the letter e*/






static void showCharacter() {
    Console.WriteLine("Enter in a word.");
    string stringObject =  Console.ReadLine();
    Console.WriteLine("Enter in the position");
    string string_position = Console.ReadLine();
    //int intergerObject = Convert.ToInt16(charPosition);
    Console.WriteLine(stringObject + "," + /*intergerObject*/ " " + string_position);
}

showCharacter();

/*Method 2: Retail Price
Write a method that asks the user to enter an 
item’s wholesale cost and its markup percentage. 
It should then display the item’s retail price. For example:
If an item’s wholesale cost is 5.00 and its markup 
percentage is 100 percent, then the item’s retail price is 10.00.
If an item’s wholesale cost is 5.00 and its markup 
percentage is 50 percent, then the item’s retail price is 7.50.
The method is named CalculateRetail that receives the 
wholesale cost and the markup percentage as arguments 
and returns the retail price of that item.*/

static void retailPrice() {
    Console.WriteLine("Please enter in a price");
    string userRetailInString = Console.ReadLine();
    double userWholePrice = Convert.ToDouble(userRetailInString);
    Console.WriteLine("Please enter in the percentage as #%");
    string userPercentageString = Console.ReadLine();
    double userPercentage = Convert.ToDouble(userPercentageString);
    var percentage = 0.0;
    if (userPercentageString  == "100%" || userPercentage <= 100)
    {
        percentage = userWholePrice * 2.0;
        Console.WriteLine(percentage + " " + userWholePrice + " " + userPercentage);
    } else if (userPercentageString == "75%" || userPercentage <= 75) {
        percentage = userWholePrice * 1.0;
        Console.WriteLine(userPercentageString+ " " + userWholePrice + " " + userPercentage);
    } else if (userPercentageString == "50%" || userPercentage <= 50) {
        percentage = userWholePrice * .50;
        Console.WriteLine(userPercentageString+ " " + userWholePrice + " " + userPercentage);
    } else if (userPercentageString == "25%" || userPercentage <= 25) {
        percentage = userWholePrice * .25;
        Console.WriteLine(userPercentageString+ " " + userWholePrice + " " + userPercentage);
    } else {
        percentage = userWholePrice * .10;
        Console.WriteLine(userPercentageString+ " " + userWholePrice + " " + userPercentage);
    }
    
}

retailPrice();

/*Method 3: Temperature Table
The formula for converting a temperature from Fahrenheit to Celsius is listed below:
C = 5/9 (F - 32)
F is the Fahrenheit temperature and C is the Celsius temperature. Write a method named Celsius 
that accepts a Fahrenheit temperature as an argument. The method should return the temperature, converted to Celsius.
Demonstrate the method by calling it in a loop that displays a table of the Fahrenheit temperatures 
80 through 100 and their celsius equivalents.
*/

static void Celsius() {
    Console.WriteLine("Please enter in the fahrenheit");
    string userInputOffahrenheit = Console.ReadLine();
    double fahrenheit = Convert.ToDouble(userInputOffahrenheit);
    var fahrenheitIntoCelsius = (fahrenheit - 32.0) * 5/9;
    Console.WriteLine(fahrenheitIntoCelsius);
   
}

Celsius();


/*
Method 4: Prime Numbers
A prime number is a number that is evenly divisible only by itself and 1. For example, 
the number 5 is prime because it can be evenly divided only by 1 and 5. The number 6, however, 
is not prime because it can be divided evenly by 1, 2, 3, and 6.
Write a method named IsPrime, which takes an integer as an argument, and returns true 
if the argument is a prime number, or false otherwise. Demonstrate the method in a complete program.
*/

static void primeNumbers() {

}