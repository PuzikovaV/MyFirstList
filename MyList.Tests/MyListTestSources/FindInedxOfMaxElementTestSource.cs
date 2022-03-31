using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class FindInedxOfMaxElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 8, 2, 6 });
            int expectedFindInedxOfMaxElement = 0;
            yield return new object[] { list, expectedFindInedxOfMaxElement };

            list = new AList(new int[] { 1, 25, 2 });
            expectedFindInedxOfMaxElement = 1;
            yield return new object[] { list, expectedFindInedxOfMaxElement };
        }
    }
}
