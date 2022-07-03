//Function 1;
static IEnumerable<string> GetSeason()
{
    string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };
    List<string> seasonslist = new List<string>();
    foreach (var s in seasons)
        seasonslist.Add(s);
    return seasonslist;
}
//Function 2;
  static  IEnumerable<string> GetSeason2()
{
    string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };
    foreach (var s in seasons)
        yield return s;
}
//Function 3;
  static  IEnumerable<string> GetSeason3()
{
    //It's unusual to repeatedly use the return keyword in a method like this
    yield return "Winter";
    yield return "Spring";
    yield return "Summer";
    yield return "Autumn";
}

foreach (var s in GetSeason())
    Console.WriteLine(s);

Console.WriteLine("*************");

foreach (var s in GetSeason2())
    Console.WriteLine(s);

Console.WriteLine("*************");
foreach (var s in GetSeason3())
    Console.WriteLine(s);

//Console.Read();
Console.WriteLine("functions 1,2,3 end here");
Console.WriteLine("*************");
////Output;
/////*****
//Winter
//Spring
//Summer
//Autumn
//*************
//Winter
//Spring
//Summer
//Autumn
//*************
//Winter
//Spring
//Summer
//Autumn
///*****
///

//As soon as the compiler sees the yield keyword, it detects
//that the block containing this keyword is an iterator block.
//During the process, in every request to the iterator method 
//    in the foreach loop, the iterator method 
//    is run from where it left off instead of starting over.
//Because compiler stores the place where the iterator method
//was left before this operation is done.

//We can use the yield keyword in two different ways as follows;
//	yield return [value]
//	yield break

//By using "yield return [value]", we can work as in our example above. 
//    However, with the "yield break" statement, the information that the 
//    iterator in the iterator 
//    has ended is reported to the relevant foreach loop. The code snippet
//    below exemplifies this situation.

//Function 4;
Console.WriteLine("***************************");
Console.WriteLine("***************************");
Console.WriteLine("***************************");
Console.WriteLine("yield break example");
static IEnumerable<string> GetSeason4()
{
    
    yield return "Winter";
    yield return "Spring";
    yield return "Summer";
    yield break;
    yield return "Autumn";
}

foreach (var item in GetSeason4())
    Console.WriteLine(item);

//Console.ReadLine();

//yield break example output ;

//Winter
//Spring
//Summer

Console.WriteLine("********************");
Console.WriteLine("yield break example ends here");
Console.WriteLine("********************");
Console.WriteLine("********************");
Console.WriteLine("********************");
//Finally, an iterator method using the yield keyword will not 
//    execute the yield command unless it is evaluated for foreach.
//As an example, let's consider the following method again.

static IEnumerable<string> GetSeason5()
{
    yield return "Winter";// put a break point here 
    yield return "Spring";// put a break point here 
    yield return "Summer";// put a break point here 
    yield return "Autumn";// put a break point here 
}
IEnumerable<string> seasonsEnumarable = GetSeason5();// put a break point here 

foreach (var item in seasonsEnumarable)// put a break point here 
    Console.WriteLine(item);

//Put the brakpoint on the above-mentioned places and follow the data while the code is running.




Console.WriteLine("********************");
Console.WriteLine("to see how actualy yiled changes codes behaviour check following example out;");
Console.WriteLine("********************");
Console.WriteLine("********************");
Console.WriteLine("********************");

static IEnumerable<string> GetSeason6()
{
    Console.WriteLine("Winter goes");
    yield return "Winter";
    Console.WriteLine("Spring goes");
    yield return "Spring";
    Console.WriteLine("Summer goes");
    yield return "Summer";
    Console.WriteLine("Autumn goes");
    yield return "Autumn";
}
IEnumerable<string> seasonsEnumarable2 = GetSeason6();

foreach (var item in seasonsEnumarable2)
{
    Console.WriteLine($"{item} on foreach");
    Console.WriteLine(item);
}
    

Console.ReadLine();
