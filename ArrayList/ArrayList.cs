namespace ArrayList
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            _array = new int[4];
            Length = 0;
        }

        public ArrayList(int value)
        {
            _array=new int[4];
            Length = 1;
            _array[0] = value;
            
        }

        public ArrayList(int[] array)
        {
            _array = new int[4];
            if (array.Length >= _array.Length)
            {
                UpSize();
            }
            for(int i=0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
            Length = array.Length;
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
            if (index > Length-1)
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

            for(int i=0; i<_array.Length; i++)
            {
                newArray[i] =_array[i+1];
            }
            _array = newArray;
            Length--;

        }

        public void DeleteByIndex(int index)
        {
            if (index > Length)
            {
                throw new Exception("The array does not have this index");
            }

            int[] newArray = new int[_array.Length-1];
            for (int i=0; i<index; i++)
            {
                newArray[i]=_array[i];
            }
            
            for (int i=index; i<_array.Length; i++)
            {
                newArray[i]=_array[i+1];
            }
            _array= newArray;
            Length--;
        }

        public void DeleteFewElementsFromStart(int amount)
        {
            if(amount > Length)
            {
                throw new Exception("The array does not have that much elements");
            }
            else if (Length == 0)
            {
                throw new Exception("The array is empty");
            }
            for (int i=0; i<amount; i++)
            {
                DeleteFirst();
            }
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

            for (int i = 0; i < amount; i++)
            {
                DeleteLast();
            }
        }

        public void DeleteFewElementsByIndex(int index, int amount)
        {
            if (amount > Length)
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
            int index = -1;
            for(int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    DeleteByIndex(index);
                    Length--;
                    break;
                }
            }
            return index;
        }

        public int DeleteEveryElementByValue(int value)
        {
            int index = 0;
            int counter = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    DeleteByIndex(index);
                    counter++;
                    Length--;
                }
            }
            return counter;
        }

        public void Reverse()
        {
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
            for(int i=index; i<_array.Length; i++)
            {
                newArray[i+1]=_array[i];
            }
            _array= newArray;
        }

        private void InsertAtStart()
        {
            int[] newArray = new int[_array.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
        }

    }
}