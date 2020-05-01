using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface IStatus
    {

        IEnumerable<Status> GetAll();
        IEnumerable<Status> GetStatuses { get; }
        Status Get_Status(int? id);

    }
}
