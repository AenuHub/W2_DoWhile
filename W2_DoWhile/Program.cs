// Takes user input as int, checks if it's a positive number
// then loop as intended

// Console.Write("Write a number: ");
// int userInput = int.Parse(Console.ReadLine());

// while (userInput > 0)
// {
//     Console.WriteLine("Ben bir Patika'lıyım");
//     userInput--;
// }

// Same idea with do-while loop

int userInput = 0;
Console.Write("Write a number: ");
userInput = int.Parse(Console.ReadLine());
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    userInput--;
} while (userInput > 0);

// while loop checks the condition at the beginning of the loop
// do-while loop checks the conditon at the end of the loop
// therefore, do-while guarantees the loop runs at least once