using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CB.Model.Common;


namespace BookKeeperModels
{
    [Serializable]
    public class Author: IdNameModelBase
    {
        #region Fields
        [NonSerialized]
        private ICollection<BookEdition> _editions;
        #endregion


        #region  Properties & Indexers
        [XmlIgnore]
        [ToString(OrderIndex = 20)]
        public ICollection<BookEdition> Editions
        {
            get { return _editions; }
            set { SetProperty(ref _editions, value); }
        }
        #endregion
    }
}