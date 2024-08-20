namespace ListPractiseLibrary
{
	public class StudentList
	{
		private List<string> students = new();

		public void Add(string studentFullName)
		{
			students.Add(studentFullName);
            Console.WriteLine($"Student: {studentFullName} was added!");
			ShowCount();
        }

		public void Remove(string studentFullName)
		{
			if (students.Remove(studentFullName))
			{
                Console.WriteLine($"Student: {studentFullName} was deleted!");
				ShowCount();
            }
			else
			{
                Console.WriteLine($"Student {studentFullName} wasn't found!");
            }
		}

		public void Find(string textToSearch)
		{
            Console.WriteLine($"Search result for \"{textToSearch}\":");
            foreach (var student in students.FindAll(x => x.Contains(textToSearch)))
			{
                Console.WriteLine($"Student: {student}");
            }
            Console.WriteLine($"Total: {students.FindAll(x => x.Contains(textToSearch)).Count} matches!");
        }

		private void ShowCount()
		{
			Console.WriteLine($"Total: {students.Count} students in list!");
		}
	}
}
