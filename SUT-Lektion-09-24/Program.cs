namespace SUT_Lektion_09_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    bool eq = calculator.CheckEqual<int>(15, 20);

            //    if (eq)
            //    {
            //        Console.WriteLine("The values is equal...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The values are not equal...");
            //    }

            //    bool eq2 = calculator.CheckEqual<string>("a", "A");
            //    if (eq2)
            //    {
            //        Console.WriteLine("The values is equal...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The values are not equal...");
            //    }


            // Colection generics
            //1 List
            //List<int> listInt = new List<int>();

            //listInt.Add(8);
            //listInt.Add(10);
            //listInt.Add(12);
            //listInt.Add(11);
            //listInt.Add(11);

            //listInt.Remove(10);
            //listInt.RemoveRange(1, 1);
            //listInt.RemoveAt(2);

            //int c = listInt.Count;

            //Console.WriteLine("The list Count is = {0}", c);

            //Console.WriteLine("The Capacity is {0}",listInt.Capacity);

            //foreach(int item in listInt)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, string> dictionary = new Dictionary<int, string>();

            //dictionary.Add(102, "Tobias");
            //dictionary.Add(101, "Anas");
            //dictionary.Add(103, "Pär");

            //dictionary.Remove(101);

            //Console.WriteLine(dictionary[102]);

            //foreach(KeyValuePair<int,string> item in dictionary)
            //{
            //    Console.WriteLine("Elements in our dictionary ID {0} Name {1}", item.Key, item.Value);
            //}

            //Queue

            //Queue<int> sut23queue = new Queue<int>();

            //sut23queue.Enqueue(8);
            //sut23queue.Enqueue(10);
            //sut23queue.Enqueue(12);
            //sut23queue.Enqueue(14);

            //sut23queue.Dequeue(); // Tar bort första värdet och returnerar det till en variabel.

            //sut23queue.Peek(); //Tittar på första värdet.

            //Console.WriteLine(sut23queue.Dequeue());

            //Console.WriteLine(sut23queue.Peek());

            //if (sut23queue.Contains(8))
            //{
            //    Console.WriteLine("Item exists in the queue");
            //}

            //foreach (int item in sut23queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack

            //Stack<int> sut23 = new Stack<int>();

            //sut23.Push(20);
            //sut23.Push(22);
            //sut23.Push(24);
            //sut23.Push(26);

            //int result = sut23.Peek();

            //Console.WriteLine("Element from peek result {0}",result); //Returnerar det översta objektet utan att ta bort det.

            //Console.WriteLine($"Element fron pop method: {sut23.Pop()}"); // Returnerar det översta värdet och tar bort det från stacken.

            //foreach (int item in sut23) { Console.WriteLine(item); }

            //Employee emp1 = new Employee()
            //{
            //    ID = 111,
            //    Name = "Tobias",
            //    Salary = 25000
            //};
            //Employee emp2 = new Employee()
            //{
            //    ID = 112,
            //    Name = "Anas",
            //    Salary = 23000
            //};
            //Employee emp3 = new Employee()
            //{
            //    ID = 120,
            //    Name = "Elias",
            //    Salary = 24000
            //};
            //Employee emp4 = new Employee()
            //{
            //    ID = 130,
            //    Name = "Sam",
            //    Salary = 22000
            //};

            //List<Employee> listEmp = new List<Employee>();

            //listEmp.Add(emp1);
            //listEmp.Add(emp2);
            //listEmp.Add(emp3);

            //// Insert - Lägger till ett element/värde i det index man specificerar
            //listEmp.Insert(1, emp4);

            //// Index of
            //Console.WriteLine(listEmp.IndexOf(emp3));

            //Console.WriteLine("Employee Info");
            //foreach (Employee item in listEmp)
            //{
            //    Console.WriteLine($"ID = {item.ID} \nName: {item.Name} \nSalary: {item.Salary}");
            //}

            //Employee result = listEmp[1];

            //Console.WriteLine(result.ID + result.Name + result.Salary);

            //// Contains - returnerar true eller false - tar objekt
            //if (listEmp.Contains(emp4)) { Console.WriteLine("Employee 3 objekt exists in the list."); }

            //else { Console.WriteLine("Employee 3 objekt does not exist in the list"); }

            //// Exists - returnerar true eller fals - tar lambda expresions även kallat predikat
            //if(listEmp.Exists(e => e.Name.StartsWith("T")))
            //{
            //    Console.WriteLine("Employee start with T is in the list");
            //}
            //else { Console.WriteLine("Employee starting with T is not in the list."); }

            //Employee result = listEmp.Find(e => e.Salary == 25000);

            //Console.WriteLine("ID = {0} \nName: {1} \nSalary {2}", result.ID, result.Name, result.Salary);

            ////FindLast
            //Employee res = listEmp.FindLast(x => x.Salary < 25000);

            //Console.WriteLine("ID = {0} \nName: {1} \nSalary {2}", res.ID, res.Name, res.Salary);


            ////Find All
            //List<Employee> result = listEmp.FindAll(e => e.Salary < 25000);

            //foreach (Employee item in result)
            //{
            //    Console.WriteLine("ID = {0} \nName: {1} \nSalary {2}", item.ID, item.Name, item.Salary);
            //}

            //int index = listEmp.FindIndex(e => e.Salary == 25000);
            //Console.WriteLine("Index of 25000: " + index);
        }
    }

    //public class calculator
    //{
    //    public static bool CheckEqual<T>(T val1, T val2) 
    //    {
    //        return val1.Equals(val2);
    //    }
    //}
}