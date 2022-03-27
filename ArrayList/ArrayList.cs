namespace MyArrayList
{
    public class AList
    {

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }
        public int Length { get; private set; }

        private int[] _array;

        public AList()
        {
            _array = new int[4];
            Length = 0;
        }

        public AList(int value)
        {
            _array=new int[4];
            Length = 1;
            _array[0] = value;
            
        }

        public AList(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                _array = new int[4];
                Length = 0;
            }
            else
            {
                _array = array;
                Length = array.Length;
                UpSize();
            }
        }

        public void AddLast(int value)
        {
            if(Length >= _array.Length)
            {
                UpSize();
            }
                _array[Length]=value;
                Length++;
        }

        public void AddFirst(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }

            InsertAtStart();

            _array[0]=value;
            Length++;
        }
        public void InsertByIndex(int value, int index)
        {
            if (index > Length - 1 || index<0)
            {
                throw new Exception("The array does not have this index");
            }
            if (Length >= _array.Length)
            {
                UpSize();
            }

            InsertBetweenElements(index);

            _array[index] = value;
            Length++;
        }

        public void DeleteLast()
        {
            if (Length == 0)
            {
                throw new Exception("The array is empty");
            }
            Length--;
        }

        public void DeleteFirst()
        {
            if(Length == 0)
            {
                throw new Exception("The array is empty");
            }
            int[] newArray=new int[_array.Length-1];

            for(int i=0; i<Length; i++)
            {
                newArray[i] =_array[i+1];
            }
            _array = newArray;
            Length--;

        }

        public void DeleteByIndex(int index)
        {
            if (index > Length-1 || index<0)
            {
                throw new Exception("The array does not have this index");
            }

            int[] newArray = new int[_array.Length-1];
            for (int i=0; i<index; i++)
            {
                newArray[i]=_array[i];
            }
            
            for (int i=index; i<Length; i++)
            {
                newArray[i]=_array[i+1];
            }
            _array= newArray;
            Length--;
        }

        public void DeleteFewElementsFromStart(int amount)
        {
            int newLength=Length-amount; 
            if(amount > Length)
            {
                throw new Exception("The array does not have that much elements");
            }
            else if (Length == 0)
            {
                throw new Exception("The array is empty");
            }
            int[] newArray=new int[_array.Length-amount];
            for (int i=0; i<newLength; i++)
            {
                newArray[i] = _array[i + amount];
            }
            _array = newArray;
            Length -= amount;
        }

        public void DeleteFewElementsFromTheEnd(int amount)
        {
            if (amount > Length)
            {
                throw new Exception("The array does not have that much elements");
            }
            else if (Length == 0)
            {
                throw new Exception("The array is empty");
            }

            Length -= amount;
        }

        public void DeleteFewElementsByIndex(int index, int amount)
        {
            if (amount >= Length)
            {
                throw new Exception("The array does not have that much elements");
            }
            else if (Length == 0)
            {
                throw new Exception("The array is empty");
            }
            else if (index > Length - 1)
            {
                throw new Exception("The array does not have this index");
            }
            for (int i = 0; i < amount; i++)
            {
                DeleteByIndex(index);
            }

        }

        public int ShowValueByIndex(int index)
        {
            if(index > Length - 1)
            {
                throw new Exception("The array does not have this index");
            }
            return _array[index];
        }

        public int ShowIndexByValue (int value)
        {
            int searchingIndex = -1;
            for(int i=0; i<Length; i++)
            {
                if (_array[i] == value)
                {
                    searchingIndex = i;
                    break;
                } 
            }
            return searchingIndex;
        }

        public void ChangeElementByIndex (int value, int index)
        {
            if (index > Length - 1)
            {
                throw new Exception("The array does not have this index");
            }

            _array[index] = value;
        }

        public int FindMaxElement()
        {
            if (Length == 0)
            {
                throw new Exception("The array is empty");
            }
            int max = _array[0];
            for (int i=0; i<Length; i++)
            {
                if (max < _array[i])
                {
                    max= _array[i];
                }
            }
            return max;
        }

        public int FindMinElement()
        {
            if (Length == 0)
            {
                throw new Exception("The array is empty");
            }

            int min = _array[0];
            for (int i=0; i<Length; i++)
            {
                if (min> _array[i])
                {
                    min=_array[i];
                }
            }
            return min;
        }

        public int FindIndexOfMinElement()
        {
            if (Length == 0)
            {
                throw new Exception("The array is empty");
            }

            int min = _array[0];
            int minIndex=0;
            for(int i=0;i<Length; i++)
            {
                if (min > _array[i])
                {
                    min=_array[i];
                    minIndex= i;
                }
            }
            return minIndex;
        }

        public int FindInedxOfMaxElement()
        {
            if (Length == 0)
            {
                throw new Exception("The array is empty");
            }

            int max = _array[0];
            int maxIndex = 0;
            for (int i = 0; i < Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public void SortFromMinToMax()
        {
            if (Length == 0)
            {
                throw new Exception("The array is empty");
            }

            int tmp;
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        tmp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }

        public void SortFromMaxToMin()
        {
            if (Length == 0)
            {
                throw new Exception("The array is empty");
            }

            for (int i = Length - 1; i >= 0; i--)
            {
                int tmp;
                for (int j = 0; ; j++)
                {
                    tmp = _array[j];
                    _array[j] = _array[i];
                    _array[i] = tmp;
                }
            }
        }

        public int DeleteFirstByElement(int value)
        {
            if (Length == 0)
            {
                throw new Exception("The array is empty");
            }

            int index = -1;
            for(int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    DeleteByIndex(index);
                    break;
                }
            }
            return index;
        }

        public int DeleteEveryElementByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("The array is empty");
            }

            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Length -= count;

            return count;
        }

        public void Reverse()
        {
            if (Length == 0)
            {
                throw new Exception("The array is empty");
            }

            int[] newArray=new int[Length];
            int j = 0;
            for(int i=Length-1; i>=0; i--)
            {
                newArray[j] = _array[i];
                j++;
            }
            _array= newArray;
        }


        public void Write()
        {
            for(int i=0; i < Length; i++)
            {
                Console.Write($"{_array[i]}");
            }
            Console.WriteLine();


        }
        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < Length; i++)
            {
                s += $"{_array[i]} ";
            }

            return s;
        }

        public override bool Equals(object? obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is AList))
            {
                isEqual = false;
            }
            else
            {
                AList list = (AList)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            isEqual = false;
                        }
                    }
                }
            }
            return isEqual;
        }

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        
        private void InsertBetweenElements(int index)
        {
            if (index > Length - 1)
            {
                throw new Exception("The array does not have this index");
            }

            int[] newArray = new int[_array.Length];

            for(int i=0; i<index; i++)
            {
                newArray[i]=_array[i];
            }
            for(int i=index; i< Length; i++)
            {
                newArray[i+1]=_array[i];
            }
            _array= newArray;
        }

        private void InsertAtStart()
        {
            int[] newArray = new int[_array.Length];
            for (int i = 0; i < Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
        }

    }
}