using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class IndexDoesNotExistTestSourse : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 7;
            AList list = new AList(new int[] { 5, 1, 6, 8, 9 });
            yield return new object[] { index, list };

            index = 5;
            list = new AList(new int[] { });
            yield return new object[] { index, list };

            index = -2;
            list = new AList(new int[] { 5, 1, 6, 8, 9 });
            yield return new object[] { index, list };
        }
    }
}
