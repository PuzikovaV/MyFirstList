using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            AList list = new AList(new int[] { 1, 6, 8 });
            AList expectedList = new AList(new int[] { 1, 6 });
            yield return new object[] { index, list, expectedList };

            index = 0;
            list = new AList(new int[] { 1, 6, 8 });
            expectedList = new AList(new int[] { 6, 8 });
            yield return new object[] { index, list, expectedList };

            index = 0;
            list = new AList(new int[] { 5 });
            expectedList = new AList(new int[] { });
            yield return new object[] { index, list, expectedList };
        }
    }
}
