using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Domain.Entities
{
    public class Author
    {

        private int authorId;

        private string firstName;
        private string lastName;

        private List<int> bookIds;

        public List<Book> GetAuthoredBooks()
        { // Find list of Books by author
            return new List<Book>();
        }

        public Author ConstructAuthor(int authorId)
        { // TODO create author from Raven or DB
            return new Author();
        }

        public Author GetAuthorFromCache(int authorId)
        { // TODO create author from Raven or DB after checking in Cache
            return new Author();
        }

        public string AuthorName()
        {
            return firstName + " " + lastName;
        }

    }
}
