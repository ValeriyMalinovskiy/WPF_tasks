using System;

namespace Author_s_book_list.Tools
{
    class IdGenerator
    {
        public double GenerateId()
        {
            double id = Convert.ToDouble(DateTime.Now.Ticks);
            return id;
        }
    }
}
