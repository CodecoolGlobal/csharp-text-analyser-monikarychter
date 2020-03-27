using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_text_analyser_monikarychter
{
    
    public class WordIterator:Iterator
    {
        FileContent file;
        public WordIterator(FileContent file){
           this.file = file;
        }

        public bool HasNext()
        {
           var list = file.GetLine();
           //FIXME: returns always true is problematic as can lead to infinite loop
           return true;
        }

        public string MoveNext()
        { 
           var list = file.GetLine();
           var v = list.ToString();
           return v;
        }
           
    
            
        
    
        public void Remove()
        {
           
        }

       
    }
}

