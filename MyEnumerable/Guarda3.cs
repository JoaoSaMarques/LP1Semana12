using System;

namespace MyEnumerable
{
    public class Guarda3<T>
    {
        private T item0;
        private T item1;
        private T item2;

        public Guarda3()
        {
            item0 = default(T);
            item1 = default(T);
            item2 = default(T);
        }

        public T GetItem(int i)
        {
            switch (i)
            {
                case 0:
                    return item0;
                case 1:
                    return item1;
                case 2:
                    return item2;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0:
                    item0 = item;
                    break;
                case 1:
                    item1 = item;
                    break;
                case 2:
                    item2 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
