using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 15;
            AList list = new AList(new int[] { 15, 18, 19, 25 });
            AList expectedList = new AList(new int[] { 15, 18, 19, 25, 15 });
            yield return new object[] { value, list, expectedList };

            value = -80;
            list = new AList(new int[] { });
            expectedList = new AList(new int[] { -80 });
            yield return new object[] { value, list, expectedList };

            value = 8;
            list = new AList(new int[] { 4 });
            expectedList = new AList(new int[] { 4, 8 });
            yield return new object[] { value, list, expectedList };
        }
    }
}
