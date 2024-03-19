using SampleAspNetCore.Models;
using System.Collections.Generic;

namespace SampleAspNetCore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private List<BookModel> books = new List<BookModel>();
        public int AddBook(BookModel book)
        {
            book.Id = books.Count + 1; 
            books.Add(book);
            return book.Id;
        }
        public List<BookModel> GetAllBooks()
        {
            return books;
        }

    }
}