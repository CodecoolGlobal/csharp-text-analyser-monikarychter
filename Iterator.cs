using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_text_analyser_monikarychter
{
    public interface Iterator{

        bool HasNext();

        string MoveNext();

        void Remove();
    

    }

}