using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class FindMinElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 88, 2, 6 });
            int expectedMinValue = 2;
            yield return new object[] { list, expectedMinValue };

            list = new AList(new int[] { 1, 2, 2 });
            expectedMinValue = 1;
            yield return new object[] { list, expectedMinValue };
        }
    }
}
