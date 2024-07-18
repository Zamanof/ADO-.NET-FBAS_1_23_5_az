using System;
using System.Collections.Generic;

namespace ADO_05._LINQ_for_Entities;

public partial class Faculty
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
