using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ILibraryCard
    {
        IEnumerable<LibraryCard> GetAll();
        void Add(LibraryCard newLibCard);
    }
}
