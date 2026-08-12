using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System___Modified__
{
    public interface ISearchable
    {
        List<Book> SearchBook(string keyword);
    }
}
