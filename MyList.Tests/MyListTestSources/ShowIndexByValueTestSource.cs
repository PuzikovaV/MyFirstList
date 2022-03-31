using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class ShowIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            AList list = new AList(new int[] { 88, 6, 25, 5 });
            int expectedIndex = 3;
            yield return new object[] { value, list, expectedIndex };

            value = 88;
            list = new AList(new int[] { 88, 6, 25, 5 });
            expectedIndex = 0;
            yield return new object[] { value, list, expectedIndex };
        }
    }
}
