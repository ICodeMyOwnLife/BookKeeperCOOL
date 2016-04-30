using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CB.Model.Common;


namespace BookKeeperModels
{
    [Serializable]
    public class Publisher: IdNameModelBase
    {
        #region Fields
        [NonSerialized]
        private ICollection<BookTitle> _titles;
        #endregion


        #region  Properties & Indexers
        [XmlIgnore]
        [ToString(OrderIndex = 20)]
        public ICollection<BookTitle> Titles
        {
            get { return _titles; }
            set { SetProperty(ref _titles, value); }
        }
        #endregion
    }
}