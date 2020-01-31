using System;

namespace Author_s_book_list.Tools
{
    internal class IdGenerator
    {
        private static int counter = 0;
        public static int GenerateId()
        {
            return ++counter;
        }
    }
}
