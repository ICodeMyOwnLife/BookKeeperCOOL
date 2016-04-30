using System;
using System.Xml.Serialization;
using CB.Model.Common;


namespace BookKeeperModels
{
    [Serializable]
    public class BookItem: IdModelBase
    {
        #region Fields
        [NonSerialized]
        private EbookType _ebookType;

        private int _ebookTypeId;

        [NonSerialized]
        private BookEdition _edition;

        private string _filePath;
        private string _isbn;
        #endregion


        #region  Properties & Indexers
        [XmlIgnore]
        [ToString(OrderIndex = 50)]
        public EbookType EbookType
        {
            get { return _ebookType; }
            set { SetProperty(ref _ebookType, value); }
        }

        [ToString(OrderIndex = 40)]
        public int EbookTypeId
        {
            get { return _ebookTypeId; }
            set { SetProperty(ref _ebookTypeId, value); }
        }

        [XmlIgnore]
        [ToString(OrderIndex = 30)]
        public BookEdition Edition
        {
            get { return _edition; }
            set { SetProperty(ref _edition, value); }
        }

        [ToString(OrderIndex = 60)]
        public string FilePath
        {
            get { return _filePath; }
            set { SetProperty(ref _filePath, value); }
        }

        [ToString(OrderIndex = 20)]
        public string Isbn
        {
            get { return _isbn; }
            set { SetProperty(ref _isbn, value); }
        }
        #endregion
    }
}