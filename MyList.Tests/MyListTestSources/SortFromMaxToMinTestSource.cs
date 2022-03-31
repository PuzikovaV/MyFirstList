using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class SortFromMaxToMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 12, 6, 2, 8 });
            AList expectedList = new AList(new int[] { 12, 8, 6, 2 });
            yield return new object[] { list, expectedList };

            list = new AList(new int[] { 1, 2, 1, 3 });
            expectedList = new AList(new int[] { 3, 2, 1, 1 });
            yield return new object[] { list, expectedList };
        }
    }
}
