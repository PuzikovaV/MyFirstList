using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 1, 5, 9, 20 });
            AList expectedList = new AList(new int[] { 1, 5, 9 });
            yield return new object[] { list, expectedList };

            list = new AList(new int[] { 1, 5 });
            expectedList = new AList(new int[] { 1 });
            yield return new object[] { list, expectedList };

            list = new AList(new int[] { 1 });
            expectedList = new AList(new int[] { });
            yield return new object[] { list, expectedList };

        }
    }
}
