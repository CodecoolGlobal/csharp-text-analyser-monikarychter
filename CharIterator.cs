using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_text_analyser_monikarychter{
    public class CharlIterator:Iterator

    {  
        FileContent file;
        public CharlIterator(FileContent file){
           this.file = file;
        }


        public bool HasNext(){
          file.GetLine();
          return true;
          
        }
        public string MoveNext()
        {
            List<string> list = file.GetLine();
            var i = list;
            return i.ToString(); 
        }

        public void Remove()
        {
            
        }
    }
}