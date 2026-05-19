using System;
using System.Data;

namespace EduNova.Data.Repositories
{
    public class LibraryRepository
    {
        public static DataTable GetAllBooks()
        {
            return SqlHelper.ExecuteDataTable("sp_GetLibraryBooks");
        }

        public static int InsertBook(string title, string isbn, string author, string category, int totalCopies)
        {
            return SqlHelper.ExecuteNonQuery("sp_InsertLibraryBook",
                SqlHelper.Param("@Title", title),
                SqlHelper.Param("@ISBN", isbn),
                SqlHelper.Param("@Author", author),
                SqlHelper.Param("@Category", category),
                SqlHelper.Param("@TotalCopies", totalCopies));
        }

        public static int UpdateBook(int bookId, string title, string isbn, string author, string category, int totalCopies)
        {
            return SqlHelper.ExecuteNonQuery("sp_UpdateLibraryBook",
                SqlHelper.Param("@BookId", bookId),
                SqlHelper.Param("@Title", title),
                SqlHelper.Param("@ISBN", isbn),
                SqlHelper.Param("@Author", author),
                SqlHelper.Param("@Category", category),
                SqlHelper.Param("@TotalCopies", totalCopies));
        }

        public static int DeleteBook(int bookId)
        {
            return SqlHelper.ExecuteNonQuery("sp_DeleteLibraryBook",
                SqlHelper.Param("@BookId", bookId));
        }

        public static int IssueBook(int bookId, int studentId, DateTime dueDate)
        {
            return SqlHelper.ExecuteNonQuery("sp_Library_IssueBook",
                SqlHelper.Param("@BookId", bookId),
                SqlHelper.Param("@StudentId", studentId),
                SqlHelper.Param("@DueDate", dueDate));
        }

        public static int ReturnBook(int issueId)
        {
            return SqlHelper.ExecuteNonQuery("sp_Library_ReturnBook",
                SqlHelper.Param("@IssueId", issueId));
        }

        public static DataTable GetIssuedBooks()
        {
            return SqlHelper.ExecuteDataTable("sp_GetIssuedBooks");
        }

        public static DataTable GetFinePolicies()
        {
            return SqlHelper.ExecuteDataTable("sp_GetLibraryFinePolicies");
        }
    }
}
