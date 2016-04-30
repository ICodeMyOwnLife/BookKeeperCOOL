using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CB.Model.Common;


namespace BookKeeperModels
{
    [Serializable]
    public class BookTopic: IdModelBase
    {
        #region Fields
        private string _folderPath;

        [NonSerialized]
        private ICollection<BookTopic> _subTopics;

        [NonSerialized]
        private BookTopic _superTopic;

        private int _superTopicId;

        [NonSerialized]
        private ICollection<BookTitle> _titles;

        private string _topic;
        #endregion


        #region  Properties & Indexers
        [ToString(OrderIndex = 30)]
        public string FolderPath
        {
            get { return _folderPath; }
            set { SetProperty(ref _folderPath, value); }
        }

        [XmlIgnore]
        public ICollection<BookTopic> SubTopics
        {
            get { return _subTopics; }
            set { SetProperty(ref _subTopics, value); }
        }

        [XmlIgnore]
        [ToString(OrderIndex = 50)]
        public BookTopic SuperTopic
        {
            get { return _superTopic; }
            set { SetProperty(ref _superTopic, value); }
        }

        [ToString(OrderIndex = 40)]
        public int SuperTopicId
        {
            get { return _superTopicId; }
            set { SetProperty(ref _superTopicId, value); }
        }

        [XmlIgnore]
        [ToString(OrderIndex = 60)]
        public ICollection<BookTitle> Titles
        {
            get { return _titles; }
            set { SetProperty(ref _titles, value); }
        }

        [ToString(OrderIndex = 20)]
        public string Topic
        {
            get { return _topic; }
            set { SetProperty(ref _topic, value); }
        }
        #endregion
    }
}