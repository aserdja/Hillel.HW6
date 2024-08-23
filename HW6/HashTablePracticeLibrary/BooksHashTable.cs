using System.Collections;

namespace HashTablePracticeLibrary
{
	public class BooksHashTable
	{
		private Hashtable bookHashTable = new();

		public void Add(string bookId, string bookName)
		{
			try
			{
				bookHashTable.Add(bookId, bookName);
				Console.WriteLine($"Book \"{bookHashTable[bookId]?.ToString()}\" ({bookId}) was added to e-library!");
			}
			catch (Exception)
			{
				Console.WriteLine($"Book with the same identifier is already in the library!");
			}
		}

		public void Remove(string bookId)
		{
			if (bookHashTable.ContainsKey(bookId))
			{
                Console.WriteLine($"Book \"{bookHashTable[bookId]?.ToString()}\" ({bookId}) was removed!");
				bookHashTable.Remove(bookId);
            }
			else
			{
                Console.WriteLine($"No book with {bookId} identifier found!");
            }
		}

		public void FindById(string bookId)
		{
			if (bookHashTable.ContainsKey(bookId))
			{
                Console.WriteLine($"Result: \"{bookHashTable[bookId]?.ToString()}\" ({bookId})");
            }
			else
			{
                Console.WriteLine($"No book found for your request!");
            }
		}
	}
}
