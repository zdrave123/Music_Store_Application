using MusicStore.Domain.Domain.BookStoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interface
{
    public interface IBookService
    {
        List<BookInfo> GetBooksInStores();
        List<Book> GetBooks();
        List<BookStore> GetBookStores();
    }
}
