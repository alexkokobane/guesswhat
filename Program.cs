// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random num = new Random();

int cpuNum = num.Next(15);



int hearts = 15;
while(hearts > 0 && hearts < 30) {
	Console.WriteLine("Guess a number between 0 and 15:");
	int userNum = Int32.Parse(Console.ReadLine());
	if(userNum != cpuNum){
		hearts--;
		Console.WriteLine($"Wrong! The right answer is {cpuNum}");
		Console.WriteLine();
		Console.WriteLine($"You have {hearts} points");
		Console.WriteLine("**************************");
		Console.WriteLine();
	} else if(userNum == cpuNum){
		Console.WriteLine("Good guess!");
		hearts++;
		Console.WriteLine($"You have {hearts} points");
		Console.WriteLine();
		Console.WriteLine("**************************");
		Console.WriteLine();
	}
};

if(hearts == 0){
	Console.WriteLine("You lose!");
} else {
	Console.WriteLine("You win!");
}