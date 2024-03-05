
static void Example1()
{
	int orderId = 3;

	switch (orderId)
	{
		case 1:
			Console.WriteLine("Computer");
			break;
		case 2:
			Console.WriteLine("Phone");
			break;
		case 3:
			Console.WriteLine("Mouse");
			break;
		default:
			Console.WriteLine("Not foun order.");
			break;
	}
}

static void Example2()
{
	Console.Write("Order count:");
	int numberOfOrders = Convert.ToInt32(Console.ReadLine());
	int totalPrice = 0;
	for (int i = 0; i < numberOfOrders; i++)
	{
		Console.Write("Order price :");
		int orderPrice = Convert.ToInt32(Console.ReadLine());
		totalPrice += orderPrice;
	}
	Console.WriteLine("Total Price:" + totalPrice);
}

static void Example3()
{
	bool isPrime = true;
	var number = 8;
	do
	{
		for (int i = 2; i < number; i++)
		{
			if (number % 2 == 0) isPrime = false;
		}
		break;
	} while (isPrime);
	string message = isPrime == true ? "Prime" : "Not prime";
	Console.Write(message);
}

static void Example4()
{
	Random rnd = new Random();
	int number = rnd.Next(1, 10);
	while (true)
	{
		Console.Write("Please predicted number enter :");
		int predictedNumer = Convert.ToInt32(Console.ReadLine());
		if (number == predictedNumer)
		{
			Console.WriteLine("Congratulations!");
			break;
		}
	}
}

static void Example5()
{
	Console.Write("Please enter a number:");
	int number = Convert.ToInt32(Console.ReadLine());
	int divisibleNumbers = 0;
	for (int i = 1; i < number; i++)
	{
		if (number % i == 0) divisibleNumbers += i;
	}
	string message = divisibleNumbers == number ? "Perfect number" : "Not perfect number";
	Console.WriteLine(message);
}

static void Example6()
{
	string message = "Arif İskilip";
	int text = message.Length;
	string upperText = message.ToUpper();
	string lowerText = message.ToLower();
	string name = message.Substring(0, 4);
	int index = message.IndexOf('İ'); //5
	string newText = message.Replace(" ", "-");
	string trimText = message.Trim();
}

static void Example7()
{
	Console.Write("Enter the number of students:");
	int studentsNumer = Convert.ToInt32(Console.ReadLine());
	List<Student> students = new();
	for (int i = 0; i < studentsNumer; i++)
	{
		Student student = new();
		Console.Write("Enter firstname:");
		student.FirstName = Console.ReadLine();
		Console.Write("Enter lastname:");
		student.LastName = Console.ReadLine();
		Console.Write("Enter note 1:");
		student.Note1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter note 2:");
		student.Note2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter note 3:");
		student.Note3 = Convert.ToInt32(Console.ReadLine());

		students.Add(student);
	}

	foreach (Student student in students)
	{
		Console.WriteLine($"{student.FirstName} {student.LastName} ---- Avarage: {(double)(student.Note1 + student.Note2 + student.Note3) / 3}");
	}
}

public class Student
{
	public string? FirstName;
	public string? LastName;
	public int Note1;
	public int Note2;
	public int Note3;
}




