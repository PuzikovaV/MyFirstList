using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class InsertByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
            int index = 2;
            AList list = new AList(new int[] { 15, 18, 19, 25 });
            AList expectedList = new AList(new int[] { 15, 18, 2, 19, 25 });
            yield return new object[] { value, index, list, expectedList };

            value = 5;
            index = 0;
            list = new AList(new int[] { 7 });
            expectedList = new AList(new int[] { 5, 7 });
            yield return new object[] { value, index, list, expectedList };

            value = 19;
            index = 1;
            list = new AList(new int[] { 4, 8 });
            expectedList = new AList(new int[] { 4, 19, 8 });
            yield return new object[] { value, index, list, expectedList };
        }
    }
}
