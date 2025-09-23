using System;
using System.Collections.Generic;

namespace Lab12.Models;

public partial class AuthorIsbn
{
    public int Id { get; set; }

    public string? AuthorName { get; set; }

    public string? TitleName { get; set; }
}
