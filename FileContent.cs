using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace csharp_text_analyser_monikarychter
{
   public class FileContent: IterebleText
    {
        string fpath;
        
        public FileContent(string fpath){
            this.fpath = fpath;
        }

        public Iterator CharIterator()
        {
            return new CharlIterator(this);
        }

        public List<string> GetLine(){
            
            if (File.Exists(fpath)){
                return File.ReadAllLines(fpath).ToList();
            }
           return new List<string>();
        }

        public Iterator WordIterator()
        {
            return new WordIterator(this);
         
        }
    }
}