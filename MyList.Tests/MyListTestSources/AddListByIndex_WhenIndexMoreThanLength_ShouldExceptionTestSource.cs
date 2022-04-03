using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class AddListByIndex_WhenIndexMoreThanLength_ShouldExceptionTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList extraList = new AList(new int[] { 5, 9, 8, 5 });
            int index = 99;
            AList list = new AList(new int[] {1,2,3});
            yield return new object[] {extraList, index, list};

            extraList = new AList(new int[] { 5, 9, 8, 5 });
            index = -5;
            list = new AList(new int[] { 1, 2, 3 });
            yield return new object[] { extraList, index, list };
        }
    }
}
