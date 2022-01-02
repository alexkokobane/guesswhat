// See https://aka.ms/new-console-template for more information


int hearts = 15;
while(hearts > 0 && hearts < 30) {
	Random num = new Random();
	int cpuNum = num.Next(15);
	int defNum1 = num.Next(15);
	int defNum2 = num.Next(15);
	int[] guess = {cpuNum, defNum1, defNum2};
	Console.WriteLine("Guess the correct number from these three");
	foreach(int n in guess){
		Console.WriteLine(n);
	}
	string reader = Console.ReadLine();
	int userNum;
	if(Int32.TryParse(reader, out userNum)) return userNum;
	if(userNum != cpuNum){
		hearts--;
		Console.WriteLine();
		Console.WriteLine($"Wrong! The right answer is {cpuNum}");
		Console.WriteLine();
		Console.WriteLine($"You have {hearts} points");
		Console.WriteLine("**************************");
		Console.WriteLine();
	} else if(userNum == cpuNum){
		hearts++;
		Console.WriteLine();
		Console.WriteLine("Good guess!");
		Console.WriteLine();
		Console.WriteLine($"You have {hearts} points");
		Console.WriteLine("**************************");
		Console.WriteLine();
	}
};

if(hearts == 0){
	Console.WriteLine("You lose!");
} else {
	Console.WriteLine("You win!");
}