using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class ChangeElementByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            int index = 2;
            AList list = new AList(new int[] { 15, 20, 36, 8 });
            AList expectedList = new AList(new int[] { 15, 20, 5, 8 });
            yield return new object[] { value, index, list, expectedList };

            value = 165;
            index = 0;
            list = new AList(new int[] { 15, 20, 36, 8 });
            expectedList = new AList(new int[] { 165, 20, 36, 8 });
            yield return new object[] { value, index, list, expectedList };
        }
    }
}
