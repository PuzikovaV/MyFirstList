using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class AddListInTheStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList extraList = new AList(new int[] { 5, 6, 9 });
            AList list = new AList(new int[] { 2, 3 });
            AList expectedList = new AList(new int[] { 5, 6, 9, 2, 3 });
            yield return new object[] { extraList, list, expectedList };

            extraList = new AList(new int[] { 7, 77, 777 });
            list = new AList(new int[] { 3, 33, 333 });
            expectedList = new AList(new int[] { 7, 77, 777, 3, 33, 333 });
            yield return new object[] { extraList, list, expectedList };

            extraList = new AList(new int[] { 7 });
            list = new AList(new int[] { });
            expectedList = new AList(new int[] { 7 });
            yield return new object[] { extraList, list, expectedList };

            extraList = new AList(new int[] { 7 });
            list = new AList(new int[] { 9 });
            expectedList = new AList(new int[] { 7, 9 });
            yield return new object[] { extraList, list, expectedList };

        }
    }
}
