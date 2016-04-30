using System.Data.Entity.ModelConfiguration;
using BookKeeperModels;


namespace BookKeeperEntityFramework
{
    public class BookItemMap: EntityTypeConfiguration<BookItem>
    {
        #region  Constructors & Destructor
        public BookItemMap() { }
        #endregion
    }
}