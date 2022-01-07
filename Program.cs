// See https://aka.ms/new-console-template for more information


int hearts = 15;
while(hearts > 0 && hearts < 30) {
	Random num = new Random();
	int randomPoints = num.Next(0,6);
	int cpuNum = num.Next(50);
	int defNum1 = num.Next(50);
	int defNum2 = num.Next(50);
	int defNum3 = num.Next(50);
	int defNum4 = num.Next(50);
	int defNum5 = num.Next(50);
	int[] guess = {cpuNum, defNum1, defNum2, defNum3, defNum4, defNum5};
	guess = guess.OrderBy(arr => num.Next()).ToArray();
	Console.WriteLine(">>Guess the correct number from these three!!");
	foreach(int n in guess){
		Console.Write(n+" ");
	}
	Console.WriteLine();
	Console.Write("Ans: ");
	int userNum = Int32.Parse(Console.ReadLine());
	System.Threading.Thread.Sleep(1000);
	if(userNum != cpuNum){
		int points = hearts-randomPoints;
		Console.WriteLine();
		Console.WriteLine($"Wrong! The right answer is {cpuNum}");
		Console.WriteLine();
		Console.WriteLine($"You have {points} points");
		Console.WriteLine("**************************");
		Console.WriteLine();
		System.Threading.Thread.Sleep(1000);
		Console.Write("Press enter :(");
		Console.ReadKey();
	} else if(userNum == cpuNum){
		int points = hearts+randomPoints;
		Console.WriteLine();
		Console.WriteLine("Good guess!");
		Console.WriteLine();
		Console.WriteLine($"You have {points} points");
		Console.WriteLine("**************************");
		Console.WriteLine();
		System.Threading.Thread.Sleep(1000);
		Console.Write("Enter any key :)");
		Console.ReadKey();
	}
};

if(hearts <= 0){
	Console.WriteLine("You lose!");
} else {
	Console.WriteLine("You win!");
}