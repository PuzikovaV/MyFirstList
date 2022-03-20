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
            Length--;
        }

        public void DeleteFirst()
        {
            int[] newArray=new int[_array.Length];

            for(int i=0; i<newArray.Length; i++)
            {
                newArray[i] =_array[i+1];
            }
            _array = newArray;

        }

        public void DeleteByIndex(int index)
        {
            int[] newArray = new int[_array.Length];
            
            for (int i=index; i<newArray.Length; i++)
            {
                newArray[i]=_array[i+1];
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
            for(int i=0; i<_array.Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
        }

    }
}