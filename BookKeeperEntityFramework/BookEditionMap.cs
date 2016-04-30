using System.Data.Entity.ModelConfiguration;
using BookKeeperModels;


namespace BookKeeperEntityFramework
{
    public class BookEditionMap: EntityTypeConfiguration<BookEdition>
    {
        #region  Constructors & Destructor
        public BookEditionMap()
        {
            HasMany(e => e.Authors).WithMany(a => a.Editions);
        }
        #endregion
    }
}



// TODO: Save many-to-many-relationship entities