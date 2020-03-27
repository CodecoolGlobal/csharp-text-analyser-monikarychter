using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace csharp_text_analyser_monikarychter
{

    public class View{
     

        
        public void PrintStr(string elements)
        {   var i = 0;
            foreach (var element in elements)
            {
              if(i> 0){
                Console.WriteLine(", ");
               
            
              }  
            }
            Console.WriteLine(elements);
        }


        public void PrintList(List<string> list) => Console.WriteLine(list);
        public void PrintDict( HashSet<string> dictSet){
          ///stat.DictionarySize();

      }

        internal static void PrintList(object list)
        {
           list = new List<string>();  
        }

        internal static void PrintStr(WordIterator iterator)
        {
            throw new NotImplementedException();
        }
    }
}