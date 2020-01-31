using Author_s_book_list.Tools;

namespace Author_s_book_list.Class
{
    public class EntityBase
    {
        public int Id { get; set; }

        public bool IsNew { get; set; }

        public EntityBase(bool isNew = true)
        {
            this.Id = IdGenerator.GenerateId();
            this.IsNew = isNew;
        }
    }
}
