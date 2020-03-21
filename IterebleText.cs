using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_text_analyser_monikarychter
{
    public interface IterebleText
    {
        Iterator CharIterator();
            //iterator
        
        Iterator WordIterator();
            
        
    }
}