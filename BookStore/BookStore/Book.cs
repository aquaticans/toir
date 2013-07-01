using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Domain.Entities
{
    public class Book
    {

        #region Fields
        private List<int> authorIds;

        public List<int> AuthorIds
        {
            get { return authorIds; }
            set { authorIds = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private List<string> genres;

        public List<string> Genres
        {
            get { return genres; }
            set { genres = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private DateTime publishDate;

        public DateTime PublishDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        #endregion

        #region Methods

        public Book ConstructBook(int bookId)
        { // TODO create author from Raven or DB
            return new Book();
        }

        public Book GetBookFromCache(int bookId)
        { // TODO create book from Raven or DB after checking in Cache
            return new Book();
        }

        #endregion
    }
}
