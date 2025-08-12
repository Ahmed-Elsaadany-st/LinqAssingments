

namespace LinqAssingment01

{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }

    }
}
