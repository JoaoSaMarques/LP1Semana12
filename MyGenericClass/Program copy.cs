using System;

namespace MyGenericClass
{
    public class Guarda3
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
    }
}
