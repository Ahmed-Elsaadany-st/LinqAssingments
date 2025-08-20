
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading;
using static LinqAssingment01.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
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
            #region 9. Get the total units in stock for each product category.
            //var result= ProductsList.GroupBy(p => p.Category)
            //            .Select(g => new { g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 10. Get the cheapest price among each category's products
            //var cheapestInEachCategory = ProductsList.GroupBy(c => c.Category).Select(g => new { g.Key, cheapest = g.Min(p => p.UnitPrice) });
            //foreach (var item in cheapestInEachCategory)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 11. Get the products with the cheapest price in each category (Use Let)
            //var result = from p in ProductsList
            //             group p by p.Category into g
            //             let minPrice = g.Min(p => p.UnitPrice)
            //             from prod in g
            //             where prod.UnitPrice == minPrice
            //             select new
            //             {
            //                 Category=g.Key,prodName=prod.ProductName,prodPrice=prod.UnitPrice

            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 12. Get the most expensive price among each category's products.
            //var result = ProductsList.GroupBy(c => c.Category).Select(g => new { Category = g.Key, most_Expensive = g.Max(p => p.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 13. Get the products with the most expensive price in each category
            //var result = ProductsList.GroupBy(c => c.Category).Select(g => new { Category = g.Key, most_Expensive = g.OrderByDescending(p => p.UnitPrice).Select(p => new {p.ProductID,p.ProductName,p.UnitPrice}).FirstOrDefault()});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 14. Get the average price of each category's products.
            //var result = ProductsList.GroupBy(c => c.Category).Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

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
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var pairs = from a in numbersA
            //            from b  in numbersB
            //            where a < b
            //            select new { A = a, B = b }
            //          ;
            //    Console.WriteLine("Pairs where a < b:");
            //     foreach (var pair in pairs)
            //     {
            //         Console.WriteLine($"{pair.A} is less than {pair.B}");
            //     }
            #region Explain
            /*from a in numbersA → يبدأ يمر على كل عنصر في numbersA.
              
              from b in numbersB → لكل a، يمر على كل عناصر numbersB (تكرار متداخل).
              
              where a < b → فلترة، نحتفظ فقط بالأزواج التي تحقق الشرط.
              
              select new { ... } → نرجع كل زوج في كائن مجهول النوع (anonymous type).*/
            #endregion
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
            #region LINQ - Set Operators
            #region 1. Find the unique Category names from Product List
            //var result = ProductsList
            //    .Select(p => p.Category)
            //    .Distinct();
            //foreach (var element in result)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion
            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductsList.Select(p => p.ProductName[0]).Union(CustomersList.Select(c => c.CustomerName[0])).ToList();
            //foreach (var element in result)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion
            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProductsList.Select(p => p.ProductName[0]).Intersect(CustomersList.Select(c => c.CustomerName[0])).ToList();
            //foreach (var element in result)
            //{
            //    Console.WriteLine( element);
            //}
            #endregion
            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductsList.Select(p => p.ProductName[0]).Except(CustomersList.Select(c => c.CustomerName[0])).ToList();
            //foreach (var element in result)
            //{
            //    Console.WriteLine( element);
            //}
            #endregion
            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProductsList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)).Concat(CustomersList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3))).ToList();
            //foreach (var element in result)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion
            #endregion
            #region LINQ - Partitioning Operators
            //Note:TakeWhile,SkipWhile onec the condition is false it stops passing over the remaining elements ulike Where it filters all elements
            #region 1. Get the first 3 orders from customers in Seattle
            //string cityName = "Washington";
            //string cityname = "Seattle";
            //var result = CustomersList.Where(c => c.City == cityname)
            //                          .SelectMany(c => c.Orders)
            //                          .Take(3);

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //}

            //there is no city named Washington

            #region Cities
            //var cities = CustomersList.Select(c => c.City).Distinct();
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}
            #endregion
            #endregion
            #region 2. Get all but the first 2 orders from customers in Seattle.
            //var result = CustomersList.Where(C => C.City == "Seattle").SelectMany(o => o.Orders).Skip(2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] Nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Nums.TakeWhile((x,y)=>x>y).ToList();
            //foreach (var element in result)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion
            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=nums.SkipWhile(n=>n%3!=0).ToList();
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = nums.SkipWhile((val, index) => val > index);
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #endregion
            #region LINQ - Quantifiers
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var lines = File.ReadAllLines("dictionary_english.txt").ToArray();
            //var result = lines.Any(w => w.Contains("ei"));
            //Console.WriteLine(result);
            #endregion
            #region 2. Return grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductsList.GroupBy(c => c.Category)
            //    .Where(g=>g.Any(p=>p.UnitsInStock==0))
            //    .Select(g => new { Category = g.Key, Products = g.ToList() });

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Category}");
            //    foreach (var product in group.Products)
            //    {
            //        Console.WriteLine($"   {product.ProductName} - Stock: {product.UnitsInStock}");
            //    }
            //}
            #endregion
            #region 3. Return a grouped list of products only for categories that have all of their products in stock.
            //var result=ProductsList.GroupBy(c=>c.Category)
            //    .Where(g=>g.All(p=>p.UnitsInStock!=0))
            //    .Select(g => new {Category=g.Key,Products=g.ToList()});

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category=> {group.Category}");
            //    foreach (var product in group.Products)
            //    {
            //        Console.WriteLine($"--------{product.ProductName}-{product.UnitsInStock}");
            //    }
            //}
            #endregion

            #endregion
            #region LINQ – Grouping Operators
            #region 1.Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> nums = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = nums.GroupBy(n => n % 5);
            //foreach (var Group in result)
            //{
            //    Console.WriteLine($"Reminder=>{Group.Key}");
            //    foreach (var num in Group)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            #endregion
            #region 2.Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input
            //var lines = File.ReadAllLines("dictionary_english.txt");
            //var result = lines.GroupBy(w => w[0]).OrderBy(g => g.Key); 
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Word that begins with Letter {group.Key}");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine($"----{word}");
            //    }

            //}


            #endregion
            #region 3. Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };
            //var result = Arr.GroupBy(w => new string(w.OrderBy(c => c).ToArray())
            //);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Words with these Characters {group.Key}");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine($"--{word}");
            //    }
            //}
            #endregion
            #endregion

            #endregion
        }

    }
}
