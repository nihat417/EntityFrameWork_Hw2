using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Hw2.Models;

public class Books
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Pages { get; set; }
    public DateTime YearPress { get; set; }
    public int Id_Themes { get; set; }
    public int Id_Category { get; set; }
    public int Id_Author { get; set; }
    public int Id_Press { get; set; }
    public string Commennt { get; set; }
    public int Quantity { get; set; }
}
