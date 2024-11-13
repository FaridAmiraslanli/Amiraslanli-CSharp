using System;

public class Task {
  public static void Main(string[] args) {

    //If the entered number is greater than 7, then print “Hello”

    

        int number = GetValidNumber();

        if (number > 7) {
          Console.WriteLine("Hello");
        }
      
    

    //If the entered name matches “John”, then output “Hello, John”, if not, then output "There is no such name"

    string name = GetValidName().ToLower();

const string targetName = "john";

string humanReadableName = char.ToUpper(targetName[0]) + targetName[1..];

Console.WriteLine(name == targetName ? $"Hello, {humanReadableName}" : "There is no such name");

    //There is a numeric array at the input, it is necessary to output array elements that are multiples of 3

    int[] input = GetValidArray();

    Console.WriteLine("Elements that are multiples of 3: ");
    foreach(var item in input) {
      if (item != 0 && item % 3 == 0) {
        Console.WriteLine(item);
      }
    }

    //Given bracket sequence: [((())()(())]]
    //Can this sequence be considered correct?
    //If the answer to the previous question is “no”, then what needs to be changed in it to make it correct?

    //Answer: No, every opening bracket must have a corresponding closing bracket.
    //To fix it, replace the second-to-last "]" with ")": [((())()(()))].

  }

static int GetValidNumber(){
 
    Console.Write("Please enter an integer: ");

      try {
        int number = int.Parse(Console.ReadLine() ?? "");
return number;

        
      } catch (FormatException) {
        Console.WriteLine("Invalid input. Try again.");
return GetValidNumber();
      }
    
}
  static string GetValidName() {
    string name = "";
    bool nameIsEmpty = true;

    while (nameIsEmpty) {
      Console.Write("Enter a name: ");
      name = Console.ReadLine() ?? "";

      if (!string.IsNullOrWhiteSpace(name)) {
        nameIsEmpty = false;

      } else {
        Console.WriteLine("Name cannot be empty.");
      }

    }
    return name;
  }

  static int[] GetValidArray() {
    try {
      Console.WriteLine("Enter an integer array (ex: 7,-5,3): ");
      string input = Console.ReadLine() ?? "";

      int[] properArray = input.Split(',').Select(int.Parse).ToArray();
      return properArray;
    } catch (FormatException) {
      Console.WriteLine("Invalid input. Try again.");
      return GetValidArray();
    }
  }
}
