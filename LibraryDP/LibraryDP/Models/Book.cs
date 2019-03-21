using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDP.Models
{
    /// <summary>
    /// This class models a book object.
    /// </summary>
    public class Book
    {
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string publishingYear { get; set; }

        /// <summary>
        /// Constructor for Book object.
        /// </summary>
        /// <param name="inputIsbn"></param>
        /// <param name="inputTitle"></param>
        /// <param name="inputAuthor"></param>
        /// <param name="inputPublisher"></param>
        /// <param name="inputPublishingYear"></param>
        public Book(String inputIsbn, String inputTitle, String inputAuthor, String inputPublisher, String inputPublishingYear)
        {
            isbn = inputIsbn;
            title = inputTitle;
            author = inputAuthor;
            publisher = inputPublisher;
            publishingYear = inputPublishingYear;
        }
    }
}
