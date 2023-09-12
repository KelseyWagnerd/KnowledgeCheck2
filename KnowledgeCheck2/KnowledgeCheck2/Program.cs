namespace KnowledgeCheck2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Academic Club Member Adder!");
			Console.WriteLine("How many new club members do you want to add? ");
			var numberOfRecords = int.Parse(Console.ReadLine());

			var recordList = new List<ClubMember>();
			for (int i = 0; i < numberOfRecords; i++)
			{
				// In this loop, populate the object's properties using Console.ReadLine()
				var member = new StudentMember();

				Console.WriteLine("First name?");
				member.firstName = Console.ReadLine();
				
				Console.WriteLine("Last name?");
				member.lastName = Console.ReadLine();

				Console.WriteLine("Email address?");
				member.email = Console.ReadLine();

				Console.WriteLine("Briefly list your academic interests");
				member.interests = Console.ReadLine();

				Console.WriteLine("School name?");
				member.school = Console.ReadLine();

				Console.WriteLine("Program title?");
				member.program = Console.ReadLine();

				Console.WriteLine("Estimated graduation date?");
				member.graduationDate = Console.ReadLine();


				recordList.Add(member);
				Console.WriteLine("Member has been added.");
				Console.WriteLine();
			}


			// Print out the list of records using Console.WriteLine()
			Console.WriteLine();
			Console.WriteLine("List of all members added in this batch:");
			foreach (var member in recordList) 
			{ 
				Console.WriteLine(member.firstName + " " + member.lastName);
			}
		}
	}
}