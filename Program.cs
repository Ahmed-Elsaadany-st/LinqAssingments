
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static LinqAssingment01.ListGenerator;
namespace LinqAssingment01

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LinqAssingment01
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            //var Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //} 
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result = ListGenerator.ProductsList.Where(x => x.UnitsInStock > 0 && x.UnitPrice > 3);
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //} 
            #endregion
            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Where((name, value) => name.Length < value);
            //foreach (var name in Result)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion
            #endregion
            #region Demo part
            #region Example01
            //Action action = FunctionsReturnsDelegate.DelegateAction();
            //action();

            //FunctionsReturnsDelegate.DelegateAction()(); 
            #endregion
            #region Example02
            //Console.WriteLine(FunctionsReturnsDelegate.DelegatePredicate()(3));
            //Console.WriteLine(FunctionsReturnsDelegate.DelegatePredicate()(-1));
            #endregion
            #region Example03
            //char[] arr = { 'H', 'e', 'l', 'l', 'o' };
            //string word = FunctionsReturnsDelegate.DelegateFunc(arr);
            //Console.WriteLine(word); // Hello
            #endregion
            #endregion
            #endregion
            #region LinqAssignment02
            #region Task
            List<string> Names = new List<string>()
            {
                "ahmed","ali","mona","Sara","omar","Samir","Salma","Mostafa"
            };
            List<int> Numbers = new List<int> { 10, 3, 7, 15, 22, 5, 8, 30 };
            #region Names that starts with s

            var names = Names.Where(n => n.StartsWith("S", StringComparison.OrdinalIgnoreCase));
            foreach (var name in names)
            {
                //Console.WriteLine(name);
            }
            #endregion
            #region Numbers biggers than 10
            var numbers = Numbers.Where(n => n > 10);
            foreach (var number in numbers)
            {
                //Console.WriteLine(number);
            }
            #endregion
            #region First Name
            var firstName = Names.FirstOrDefault();
            //Console.WriteLine(firstName); 
            #endregion
            #region Last Number
            var lastNumber = numbers.LastOrDefault();
            //Console.WriteLine(lastNumber);
            #endregion
            #region First number bigger than 20
            //var num = Numbers.FirstOrDefault(n => n > 2000,-1);
            //Console.WriteLine(num);

            //--------------------------------------
            /*int result = numbers.Where(n => n > 20)
                    .DefaultIfEmpty(-1)
                    .First();*/
            //Console.WriteLine(result);
            #endregion
            #endregion
            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);

            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var restul = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(restul?.ProductName??"Not Found");
            #endregion
            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(num => num > 5).OrderBy(n=>n).Skip(1).First(); //7
            //Console.WriteLine(result);
            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(n => n % 2 == 1).Count();
            //Console.WriteLine(result);

            #endregion
            #region 2. Return a list of customers and how many orders each has.
            //var result = CustomersList.Select(n => new {n.CustomerName, OrdersCount = n.Orders.Count()});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Return a list of categories and how many products each has
            //var result = ProductsList.GroupBy(c => c.Category).Select(g => new { Category = g.Key, ProductsCount = g.Count() });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category}: {item.ProductsCount}");
            //}
            #endregion
            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var sum = Arr.Sum();
            // Console.WriteLine(sum);
            #endregion
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var lines = File.ReadAllLines("dictionary_english.txt");
            //var NumberOfChars=lines.Length;
            //Console.WriteLine(NumberOfChars);// Or we can Convert it to charArray and the get the sum of the elements

            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var lines = File.ReadAllLines("dictionary_english.txt");
            //var shortestWord = lines.OrderBy(w => w.Length).FirstOrDefault();
            //Console.WriteLine(shortestWord);
            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var lines = File.ReadAllLines("dictionary_english.txt");
            //var longestWord = lines.OrderByDescending(w => w.Length).FirstOrDefault();
            //Console.WriteLine(longestWord);
            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var lines = File.ReadAllLines("dictionary_english.txt");
            //var AvgLength=lines.Average(w=>w.Length);
            //Console.WriteLine((int)AvgLength);

            #endregion
            #endregion
            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //var result = ProductsList.OrderBy(n => n.ProductName);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion
            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            // Why should i use a custome comparer since String implement IComparabel!!!!!!!? 

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.Order();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(n => n.Length).ThenBy(n => n);
            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion
            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(n => n.Length).ThenBy(n => n);
            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion
            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var products = ProductsList.OrderByDescending(p => p.Category).ThenBy(p => p.UnitPrice);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion
            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(w => w.Length).ThenByDescending(w => w);
            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var List = Arr.Where(w => w[1] == 'i').Reverse();
            //foreach (var item in List)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region LINQ-Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var ProductsNames=ProductsList.Select(p=>p.ProductName).ToList();
            //foreach (var product in ProductsNames)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var UpperCasedWords=words.Select(x => x.ToUpper());
            //var LowerCasedWords=words.Select(w=>w.ToLower());
            //Console.WriteLine("-------------Lower Case---------------");
            //foreach (var word in LowerCasedWords)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.WriteLine("---------------Upper Case---------------");

            //foreach (var word in UpperCasedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var PList = ProductsList.Select(p => new {Name=p.ProductName,Price=p.UnitPrice });
            //foreach (var product in PList)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where((val, index) => val == index);
            //Console.WriteLine("Numbers in place:-");
            //foreach (var value in result)
            //{
            //    Console.WriteLine(value);
            //}
            #endregion
            #region 6. Select all orders where the order total is less than 500.00.
            //var OrderList = CustomersList.SelectMany(o => o.Orders).Where(o => o.Total < 500);
            //foreach (var order in OrderList)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion
            #region 7. Select all orders where the order was made in 1998 or later.
            //  var result = CustomersList
            //.SelectMany(c => c.Orders)
            //.Where(o => o.OrderDate.Year >= 1998);

            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #endregion

            #endregion
        }

    }
}
