using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDP.Models
{
    /// <summary>
    /// This class models a BookCopy object.
    /// </summary>
    public class BookCopy
    {
        string copyNumber { get; set; }
        Boolean isAvailable = true;
        public int loanPeriod;
    }
}
