namespace QueuePracticeLibrary
{
	public class ClientQueue
	{
		private Queue<string> clientQueue = new();

		public void Add(string name)
		{
			clientQueue.Enqueue(name);
            Console.WriteLine($"Client {name} joined the queue!");
        }

		public string Remove()
		{
			string? result = "";
			if (clientQueue.TryPeek(out result))
			{
				Console.WriteLine($"Client {result} currently in service!");
				return clientQueue.Dequeue();
			}

            Console.WriteLine($"Queue is empty!");
            return "";
		}

		public void GetQuantity()
		{
			Console.WriteLine($"There are currently {clientQueue.Count} clients in the queue!");
        }
	}
}
