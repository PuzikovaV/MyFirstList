using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 1, 5, 9, 20 });
            AList expectedList = new AList(new int[] { 5, 9, 20 });
            yield return new object[] { list, expectedList };

            list = new AList(new int[] { 4, 1 });
            expectedList = new AList(new int[] { 1 });
            yield return new object[] { list, expectedList };

            list = new AList(new int[] { 1 });
            expectedList = new AList(new int[] { });
            yield return new object[] { list, expectedList };
        }
    }
}
