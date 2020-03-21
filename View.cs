using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace csharp_text_analyser_monikarychter
{

    public class View{
     

        
        public void PrintStr(string str)
        {
            if (str is String)
            {
                throw new ArgumentNullException(nameof(str));
            }
            return;
        }


        public void PrintList(List<string> list) => Console.WriteLine(list);
        public void PrintDict( HashSet<string> dictSet){
          ///stat.DictionarySize();

      }

        internal static void PrintList(object list)
        {
           list = new List<string>();  
        }
    }
}