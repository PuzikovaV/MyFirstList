using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class FindMaxElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 88, 2, 6 });
            int expectedMaxValue = 88;
            yield return new object[] { list, expectedMaxValue };

            list = new AList(new int[] { 1, 2, 2 });
            expectedMaxValue = 2;
            yield return new object[] { list, expectedMaxValue };
        }
    }
}
