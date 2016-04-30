using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CB.Model.Common;


namespace BookKeeperModels
{
    [Serializable]
    public class BookTitle: IdModelBase
    {
        #region Fields
        [NonSerialized]
        private ICollection<BookEdition> _editions;

        [NonSerialized]
        private Publisher _publisher;

        private int _publisherId;
        private string _title;

        [NonSerialized]
        private BookTopic _topic;

        private int _topicId;
        #endregion


        #region  Properties & Indexers
        [XmlIgnore]
        [ToString(OrderIndex = 70)]
        public ICollection<BookEdition> Editions
        {
            get { return _editions; }
            set { SetProperty(ref _editions, value); }
        }

        [XmlIgnore]
        [ToString(OrderIndex = 60)]
        public Publisher Publisher
        {
            get { return _publisher; }
            set { SetProperty(ref _publisher, value); }
        }

        [ToString(OrderIndex = 50)]
        public int PublisherId
        {
            get { return _publisherId; }
            set { SetProperty(ref _publisherId, value); }
        }

        [ToString(OrderIndex = 20)]
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        [XmlIgnore]
        [ToString(OrderIndex = 40)]
        public BookTopic Topic
        {
            get { return _topic; }
            set { SetProperty(ref _topic, value); }
        }

        [ToString(OrderIndex = 30)]
        public int TopicId
        {
            get { return _topicId; }
            set { SetProperty(ref _topicId, value); }
        }
        #endregion
    }
}