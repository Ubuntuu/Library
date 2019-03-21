using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDP.Models
{
    /// <summary>
    /// Class for creating a new loan in the library.
    /// </summary>
    public class Loan
    {
        User user { get; set; }
        BookCopy bookCopy { get; set; }
        DateTime loanDate;
        DateTime loanExpirationDate;

        /// <summary>
        /// Constructor for Loan Object.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="bookCopy"></param>
        public Loan(User user, BookCopy bookCopy)
        {
            this.user = user;
            this.bookCopy = bookCopy;

            loanDate = getCurrentDate();
        }

        /// <summary>
        /// Method for returning the the current datetime.
        /// </summary>
        /// <returns>Current time</returns>
        DateTime getCurrentDate()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// Method for getting the return date for a loaned Book.
        /// </summary>
        void getReturnDate()
        {
            loanExpirationDate = loanDate.AddDays(bookCopy.loanPeriod);
        }
    }
}
