// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random num = new Random();

int cpuNum = num.Next(15);

Console.WriteLine("Guess a number between 0 and 15:");
int userNum = Int32.Parse(Console.ReadLine());

if(userNum != cpuNum){
	Console.WriteLine("Wrong! The right answer is "+cpuNum);
} else if(userNum == cpuNum){
	Console.WriteLine("Good guess!");
}