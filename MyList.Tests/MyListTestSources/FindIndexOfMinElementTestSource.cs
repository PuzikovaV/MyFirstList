using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class FindIndexOfMinElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 1, 15, 6 });
            int expectedIndexOfMinElement = 0;
            yield return new object[] { list, expectedIndexOfMinElement };

            list = new AList(new int[] { 56, 5, 100 });
            expectedIndexOfMinElement = 1;
            yield return new object[] { list, expectedIndexOfMinElement };
        }
    }
}
