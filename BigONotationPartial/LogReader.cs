using System.Collections;
using System.Collections.Generic;

namespace BigONotationPartial
{
    class LogReader : IEnumerable<LogLine>
    {
        int counter = 0;

        public IEnumerator<LogLine> GetEnumerator()
        {
            var N = 100000;
            var uniqueIPs = 90001;

            while (counter < N)
            {
                yield return new LogLine(counter % uniqueIPs);
                counter++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
