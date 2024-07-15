using System;
using System.Collections.Generic;

namespace ADO_04._Database_First_02;

public partial class Author
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
