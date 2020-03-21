using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace csharp_text_analyser_monikarychter{
    
    public class StatisticAnaliysis {
       
        Iterator iterator ;

        public View View1 { get; }

        View view1 = new View();
        private View v;

        public StatisticAnaliysis(Iterator iterator,  View view1){
            
            this.iterator = iterator;
            
            this.View1 = v;
        }



        public int CountOf(params string[] elems)

        {
            int i = 0;
            while(iterator.HasNext()){
                var item = iterator.MoveNext();
                if(elems.Contains(item)){
                    i++;
                }
            }
            return i;

            
        }
      
        
        public int DictionarySize()
        {
            //Dictionary<string, int> dict =new Dictionary<string,int>();
            HashSet<string> dictSet = new HashSet<string>();
            while(iterator.HasNext()){
                var item = iterator.MoveNext();
                dictSet.Add(item);
            }
            return dictSet.Count(); 
        
            

        }
     
        public int Size(){
           
         int i = 0;
            while(iterator.HasNext()){
                var item = iterator.MoveNext();
                  i++;
                
            }
            return i;
        }
         
             
         

    }
}