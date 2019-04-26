using System;
using System.Collections.Generic;
using System.Text;

namespace BigONotationPartial
{
    class LogLine
    {
        int counter;
        public LogLine(int counter)
        {
            this.counter = counter;
        }

        public string GetIP()
        {
            return "ip-" + counter;
        }
    }
}
