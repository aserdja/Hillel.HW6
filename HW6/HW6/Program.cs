using DictionaryPracticeLibrary;
using ListPractiseLibrary;
using QueuePracticeLibrary;
using HashTablePracticeLibrary;


var dictTest = new ContactDictionary();
dictTest.Add("Oleg", "+38091234564");
dictTest.Add("Oleg", "+38091234564");
dictTest.Add("Stas", "+38091234432");
dictTest.Add("Dan", "+38091234424");
dictTest.Add("Vasilii", "+3805842389");

dictTest.Remove("ASd");
dictTest.Remove("Dan");

dictTest.FindByName("AAds");
dictTest.FindByName("Stas");





var listTest = new StudentList();
listTest.Add("Oleg Tkach");
listTest.Add("Oleg Melnik");
listTest.Add("Vasilii Tereza");
listTest.Add("Danylo Ivanov");

listTest.Remove("invalid name");
listTest.Remove("Danylo Ivanov");

listTest.Find("Oleg");
listTest.Find("ASDASDAS");



var queueTest = new ClientQueue();
queueTest.Add("client 1");
queueTest.Add("client 2");
queueTest.Add("client 3");

queueTest.GetQuantity();

queueTest.Remove();
queueTest.GetQuantity();

queueTest.Remove();
queueTest.Remove();
queueTest.Remove();
queueTest.GetQuantity();




var hashTableTest = new BooksHashTable();
hashTableTest.Add("book-1", "Astral");
hashTableTest.Add("book-1", "Astral 2");
hashTableTest.Add("mrkmnsn", "Models");
hashTableTest.Add("fantas123", "It");

hashTableTest.Remove("book-1");
hashTableTest.Remove("boooooooook-2");

hashTableTest.FindById("asdasdasdasdas");
hashTableTest.FindById("fantas123");