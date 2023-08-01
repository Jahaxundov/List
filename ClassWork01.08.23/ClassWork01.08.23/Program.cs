
using ClassWork01._08._23.Conrollers;
using System.Collections;

//ArrayList arrayList = new ArrayList();
//arrayList.Add(5);
//arrayList.Add("salam");

//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//}

//Hashtable hashtable = new Hashtable();
//hashtable.Add(1, "Samir");
//hashtable.Add(2, "Fidan");

//foreach (DictionaryEntry item in hashtable)
//{
//    Console.WriteLine(item.Key);
//}

//SortedList sortedList = new SortedList();
//sortedList.Add(2, 5);
//sortedList.Add(1, 6);

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key);
//}

//SortedList sortedList = new SortedList();
//sortedList.Add("Az", 5);
//sortedList.Add("Ca", 6);
//sortedList.Add("Ba", 7);


//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key);
//}


//SortedList<int,string> sortedList=new SortedList<int, string>();
//sortedList.Add(1, "Argentina");
//sortedList.Add(2, "Azerbaycan");

//foreach (KeyValuePair<int,string> item in sortedList)
//{
//    Console.WriteLine(item.Value);
//}

//Dictionary<int, int> dictionary = new Dictionary<int, int>();
//dictionary.Add(1, 1);
//dictionary.Add(3, 2);
//dictionary.Add(2, 3);
//foreach (KeyValuePair<int,int> item in dictionary)
//{
//    Console.WriteLine(item.Value);
//}

//Dictionary<string, string> users = new Dictionary<string, string>();
//users.Add("admin", "Cahangir");
//users.Add("superadmin", "Sharaf");
//users.Add("member", "Pervin");

//foreach (KeyValuePair<string,string> item in users)
//{
//    if (item.Key == "admin")
//    {
//        Console.WriteLine(item.Value);
//    }
//}

//Stack<int> stack = new Stack<int>();
//stack.Push(2);
//stack.Push(3);
//stack.Push(1);
//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}

//Queue<int> queue = new Queue<int>();
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(1);
//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}

//List<int> nums = new();
//nums.Add(1);
//nums.Add(2);
//nums.Add(3);
//Console.WriteLine(nums[0]);// array kimi

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}
//int[] arr = { 1, 2, 3, 4 };
//arr.ToList();

//List<int> nums2 = new();
//nums2.Add(1);
//nums2.Add(22);
//nums2.Add(33);
//nums.AddRange(nums2);//bit listi o birine add eledi
//var result = nums.ToArray();
/*var result = nums.Count();*///arrayin  lenghti kimi
                              //nums.Remove(2);

//var result = nums.FirstOrDefault(m => m > 5);

//var result = nums.FindAll(m => m > 5);
//foreach (var item in result)
//{
//    Console.WriteLine(item);

//}

//var result = nums.Exists(x => x == 1);
//Console.WriteLine(result);



//var result = nums.Find(m => m.Equals(10)); //beraber olan 10
//Console.WriteLine(result);

//var result = nums.Where(m => m > 20 || m < 30).FirstOrDefault();

EmployeeController controller = new();
//controller.GetAll();
controller.FilterBySalary();