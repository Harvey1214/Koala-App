using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoalaApp.Data
{
    public enum SortBy
    {
        PRIORITY_LOWTOHIGH,
        PRIORITY_HIGHTOLOW,
        DUEDATE_LOWTOHIGH,
        DUEDATE_HIGHTOLOW,
        COMPLETEDDATE_LOWTOHIGH,
        COMPLETEDDATE_HIGHTOLOW
    }
}
