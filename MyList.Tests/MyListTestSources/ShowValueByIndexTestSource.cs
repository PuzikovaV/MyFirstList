using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class ShowValueByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 1;
            AList list = new AList(new int[] { 88, 25, 6 });
            int expectedValue = 25;
            yield return new object[] { index, list, expectedValue };

            index = 5;
            list = new AList(new int[] { 15, 16, 6, 9, 7, 8 });
            expectedValue = 8;
            yield return new object[] { index, list, expectedValue };
        }
    }
}
