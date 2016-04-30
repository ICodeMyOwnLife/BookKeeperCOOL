using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CB.Model.Common;


namespace BookKeeperModels
{
    [Serializable]
    public class BookEdition: ObservableObject
    {
        #region Fields
        private string _amazonUrl;

        [NonSerialized]
        private ICollection<Author> _authors;

        [NonSerialized]
        private ICollection<BookItem> _bookItems;

        private short _edition;
        private string _isbn;
        private decimal _price;
        private decimal _rating;
        private int _review;

        [NonSerialized]
        private BookTitle _title;

        private int _titleId;
        private short _year;
        #endregion


        #region  Properties & Indexers
        [ToString(OrderIndex = 80)]
        public string AmazonUrl
        {
            get { return _amazonUrl; }
            set { SetProperty(ref _amazonUrl, value); }
        }

        [XmlIgnore]
        [ToString(OrderIndex = 120)]
        public ICollection<Author> Authors
        {
            get { return _authors; }
            set { SetProperty(ref _authors, value); }
        }

        [XmlIgnore]
        [ToString(OrderIndex = 110)]
        public ICollection<BookItem> BookItems
        {
            get { return _bookItems; }
            set { SetProperty(ref _bookItems, value); }
        }

        [ToString(OrderIndex = 30)]
        public short Edition
        {
            get { return _edition; }
            set { SetProperty(ref _edition, value); }
        }

        [ToString(OrderIndex = 20)]
        public string Isbn
        {
            get { return _isbn; }
            set { SetProperty(ref _isbn, value); }
        }

        [ToString(OrderIndex = 70)]
        public decimal Price
        {
            get { return _price; }
            set { SetProperty(ref _price, value); }
        }

        [ToString(OrderIndex = 50)]
        public decimal Rating
        {
            get { return _rating; }
            set { SetProperty(ref _rating, value); }
        }

        [ToString(OrderIndex = 60)]
        public int Review
        {
            get { return _review; }
            set { SetProperty(ref _review, value); }
        }

        [XmlIgnore]
        [ToString(OrderIndex = 100)]
        public BookTitle Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        [ToString(OrderIndex = 90)]
        public int TitleId
        {
            get { return _titleId; }
            set { SetProperty(ref _titleId, value); }
        }

        [ToString(OrderIndex = 40)]
        public short Year
        {
            get { return _year; }
            set { SetProperty(ref _year, value); }
        }
        #endregion
    }
}