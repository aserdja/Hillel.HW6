namespace DictionaryPracticeLibrary
{
	public class ContactDictionary
	{
		private Dictionary<string, string> contactBook = new(); 
		
		public void Add(string name, string telephoneNumber)
		{
			var result = contactBook.TryAdd(name, telephoneNumber);
			if (result)
			{
				Console.WriteLine($"Contact: {name} ({telephoneNumber}) was added!");
			}
            else
			{
				Console.WriteLine($"Contact with name {name} already exists!");
			}
        }

		public void Remove(string name)
		{
			var number = Get(name);
			var result = contactBook.Remove(name);
			if (result)
			{
				Console.WriteLine($"Contact: {name} ({number}) was deleted!");
			}
			else
			{
                Console.WriteLine($"Contact {name} wasn't found!");
            }
				
		}

		public void FindByName(string nameToSearch)
		{
			string? result;

			if (contactBook.TryGetValue(nameToSearch, out result))
			{
                Console.WriteLine($"Desired contact: {nameToSearch} ({result})");
            }
			else
			{
                Console.WriteLine($"No one contact wasn't found!");
            }
		}

		public void ShowAll()
		{
            Console.WriteLine($"All contacts:");
            foreach (var item in contactBook)
			{
                Console.WriteLine($"Name: {item.Key}. Phone number: {item.Value}");
            }
		}

		private string? Get(string nameToSearch)
		{
			string? result;
			contactBook.TryGetValue(nameToSearch, out result);
			return result ?? null;
		}
	}
}
