using System;
using System.Data;
using EduNova.Data.Repositories;

namespace EduNova.Services
{
    public class LibraryService
    {
        public DataTable GetAll() => GetAllBooks();
        public DataTable GetAllBooks() => LibraryRepository.GetAllBooks();
        public int SaveBook(int bookId, string title, string isbn, string author, string category, int totalCopies)
        {
            if (bookId > 0)
                return LibraryRepository.UpdateBook(bookId, title, isbn, author, category, totalCopies);
            return LibraryRepository.InsertBook(title, isbn, author, category, totalCopies);
        }
        public int DeleteBook(int id) => LibraryRepository.DeleteBook(id);
        public int IssueBook(int bookId, int studentId, DateTime dueDate) => LibraryRepository.IssueBook(bookId, studentId, dueDate);
        public int ReturnBook(int issueId) => LibraryRepository.ReturnBook(issueId);
        public DataTable GetIssuedBooks() => LibraryRepository.GetIssuedBooks();
        public DataTable GetFinePolicies() => LibraryRepository.GetFinePolicies();
    }
}
