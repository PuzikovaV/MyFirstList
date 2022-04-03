using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 9, 8, 6 });
            int index = 1;
            AList extraList = new AList(new int[] { 1, 3, 2, 4 });
            AList expectedList = new AList(new int[] { 9, 1, 3, 2, 4, 8, 6 });
            yield return new object[] { extraList, index, list, expectedList };

            list = new AList(new int[] { 8 });
            index = 0;
            extraList = new AList(new int[] { -15 });
            expectedList = new AList(new int[] { -15, 8 });
            yield return new object[] { extraList, index, list, expectedList };

            list = new AList(new int[] { 8, 9 });
            index = 1;
            extraList = new AList(new int[] { });
            expectedList = new AList(new int[] { 8, 9 });
            yield return new object[] { extraList, index, list, expectedList };

            list = new AList(new int[] { 8, 9, 88 });
            index = 2;
            extraList = new AList(new int[] { 156 });
            expectedList = new AList(new int[] { 8, 9, 156, 88 });
            yield return new object[] { extraList, index, list, expectedList };
        }
    }
}
