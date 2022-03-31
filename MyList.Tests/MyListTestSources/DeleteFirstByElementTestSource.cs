using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class DeleteFirstByElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            AList list = new AList(new int[] { 1, 6, 5, 8, 9 });
            AList expectedList = new AList(new int[] { 1, 6, 8, 9 });
            int expectedIndex = 2;
            yield return new object[] { value, list, expectedList, expectedIndex };

            value = 9;
            list = new AList(new int[] { 1, 6, 5, 8, 9 });
            expectedList = new AList(new int[] { 1, 6, 5, 8 });
            expectedIndex = 4;
            yield return new object[] { value, list, expectedList, expectedIndex };
        }
    }
}
