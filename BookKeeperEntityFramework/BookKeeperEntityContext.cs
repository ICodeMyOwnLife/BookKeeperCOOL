using System.Data.Entity;
using BookKeeperModels;


namespace BookKeeperEntityFramework
{
    public class BookKeeperEntityContext: DbContext
    {
        #region  Properties & Indexers
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookEdition> BookEditions { get; set; }
        public DbSet<BookItem> BookItems { get; set; }
        public DbSet<BookTitle> BookTitles { get; set; }
        public DbSet<BookTopic> BookTopics { get; set; }
        public DbSet<EbookType> EbookTypes { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        #endregion
    }
}