using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MusicStore.Domain.Domain.BookStoreModels;
using MusicStore.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Implementation
{
    public class BookService : IBookService
    {
        private readonly string _connectionString;

        public BookService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("BookStoreConnection");
        }
        public List<BookInfo> GetBooksInStores()
        {
            var booksInfo = new List<BookInfo>();

            // SQL query to join Books and BookStores
            string sql = @"
                SELECT b.Title, b.Author, b.Genre, b.Price, s.Name AS StoreName
                FROM Books b
                INNER JOIN BooksInBookStores bb ON b.Id = bb.BookId
                INNER JOIN BookStores s ON bb.BookStoreId = s.Id
                ";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var bookInfo = new BookInfo
                            {
                                Title = reader["Title"].ToString(),
                                Author = reader["Author"].ToString(),
                                Genre = reader["Genre"].ToString(),
                                Price = Convert.ToInt32(reader["Price"]),
                                StoreName = reader["StoreName"].ToString()
                            };
                            booksInfo.Add(bookInfo);
                        }
                    }
                }
            }

            return booksInfo;
        }


        // Get all Books
        public List<Book> GetBooks()
        {
            var books = new List<Book>();

            string sql = "SELECT Id, Title, Author, Genre, Description, Isbn, CreatedAt, Price FROM Books";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var book = new Book
                            {
                                Id = Guid.Parse(reader["Id"].ToString()),
                                Title = reader["Title"].ToString(),
                                Author = reader["Author"].ToString(),
                                Genre = reader["Genre"].ToString(),
                                Description = reader["Description"].ToString(),
                                Isbn = Convert.ToInt32(reader["Isbn"]),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                Price = Convert.ToInt32(reader["Price"])
                            };
                            books.Add(book);
                        }
                    }
                }
            }

            return books;
        }

        // Get all BookStores
        public List<BookStore> GetBookStores()
        {
            var stores = new List<BookStore>();

            string sql = "SELECT Id, Name, Address, City, Email, PhoneNumber, WebsiteUrl FROM BookStores";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var store = new BookStore
                            {
                                Id = Guid.Parse(reader["Id"].ToString()),
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString(),
                                City = reader["City"].ToString(),
                                Email = reader["Email"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                WebsiteUrl = reader["WebsiteUrl"].ToString()
                            };
                            stores.Add(store);
                        }
                    }
                }
            }

            return stores;
        }
    }
}
