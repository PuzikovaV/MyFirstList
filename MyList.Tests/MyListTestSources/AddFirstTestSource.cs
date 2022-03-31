using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
            AList list = new AList(new int[] { 15, 18, 19, 25 });
            AList expectedList = new AList(new int[] { 2, 15, 18, 19, 25 });
            yield return new object[] { value, list, expectedList };

            value = 568;
            list = new AList(new int[] { });
            expectedList = new AList(new int[] { 568 });
            yield return new object[] { value, list, expectedList };

            value = 19;
            list = new AList(new int[] { 4 });
            expectedList = new AList(new int[] { 19, 4 });
            yield return new object[] { value, list, expectedList };
        }
    }
}
