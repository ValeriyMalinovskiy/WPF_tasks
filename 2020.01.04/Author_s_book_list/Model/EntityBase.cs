using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Author_s_book_list.Tools;

namespace Author_s_book_list.Class
{
    public class EntityBase
    {
        public double Id { get; set; }

        public bool IsNew { get; set; }

        public EntityBase()
        {
            this.Id = new IdGenerator().GenerateId();
            this.IsNew = true;
        }
    }
}
