
#region Heap-Stack
//int a = 5;
//int b = a;
//b = 10;
//Console.WriteLine(a);
//Console.WriteLine(b);


//int[] arr = { 1, 2, 3 };
//int[] arr2 = arr;

//arr2[0] = 100;
//Console.WriteLine(arr[0]);
//Console.WriteLine(arr2[0]);


//int n = 5;

//Test(n);
//Console.WriteLine(n);

//static void Test(int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}

//Test2(arr);
//Console.WriteLine(arr[0]);
// static void Test2(int[] arr)
//{
//    arr[0] = 200;
//    Console.WriteLine(arr[0]);

//}

//int n = 5;

//Test(ref n);
//Console.WriteLine(n);

//static void Test(ref int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}

//int n;
//Test(out n);
//Console.WriteLine(n);

//static void Test(out int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}
#endregion


#region String Methods
//string name = "Shaiq";
//string name2 = name;
//name2 = "Cavid";
//Console.WriteLine(name);
//Console.WriteLine(name2);


//string address = "Sedmoy";

//int result = address.Length;
//Console.WriteLine(result);

//C/*onsole.WriteLine(address.StartsWith("e"));*/

//Console.WriteLine(address.EndsWith("y"));

//if (address.EndsWith("y"))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

//if (address.Contains("i"))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

//var res = address.Split(",");
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(address.ToLower());

////address = "Shaiq";
////Console.WriteLine(address.ToUpper());

//string address = "roya";
//var letter = address[0].ToString().ToUpper();
//var arr = address.ToCharArray();
//arr[0] = char.Parse(letter);
//string result = "";
//foreach (var item in arr)
//{
//    result += item;

//Console.WriteLine(result);
//}

//string name = "Shaiq";
////Console.WriteLine(name.ToUpper());

////Console.WriteLine(name.Substring(1));

////Console.WriteLine(name.Trim());
//if (!string.IsNullOrEmpty(name))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}
#endregion


//Parametr olaraq string qebul eden metod yazmalisiz.
//    Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin. (Cavid gelirse , ekranda divaC gorsensin).


//Tapsiriq adi tersine yazmaq


//static void ChangeName(string name)
//{
//    string result = "";
//    for (int i = name.Length - 1; i >= 0; i--)
//    {
//        result += name[i];
//    }


//    Console.WriteLine(result);

//}

//ChangeName("Cavid");
