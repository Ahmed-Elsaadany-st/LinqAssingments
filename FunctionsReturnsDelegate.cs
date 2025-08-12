using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssingment01
{
    internal class FunctionsReturnsDelegate
    {
        public static Action DelegateAction()=>
          () => { Console.WriteLine("Hi i am a function that returns a function(Delegate object)"); };
        public static Predicate<int> DelegatePredicate() => x => x > 0;
        public static Func<char[], string> DelegateFunc => Chars => (new string(Chars));
        
    }
}
