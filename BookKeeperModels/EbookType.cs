using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CB.Model.Common;


namespace BookKeeperModels
{
    [Serializable]
    public class EbookType: IdModelBase
    {
        #region Fields
        [NonSerialized]
        private ICollection<BookItem> _bookItems;

        private string _type;
        #endregion


        #region  Properties & Indexers
        [XmlIgnore]
        [ToString(OrderIndex = 30)]
        public virtual ICollection<BookItem> BookItems
        {
            get { return _bookItems; }
            set { SetProperty(ref _bookItems, value); }
        }

        [ToString(OrderIndex = 20)]
        public string Type
        {
            get { return _type; }
            set { SetProperty(ref _type, value); }
        }
        #endregion
    }
}