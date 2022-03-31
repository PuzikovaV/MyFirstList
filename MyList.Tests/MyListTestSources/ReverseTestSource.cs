using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 1, 4, 6, 8 });
            AList expectedList = new AList(new int[] { 8, 6, 4, 1 });
            yield return new object[] { list, expectedList };

            list = new AList(new int[] { 1, 55 });
            expectedList = new AList(new int[] { 55, 1 });
            yield return new object[] { list, expectedList };

        }
    }
}
