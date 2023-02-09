using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Hw2.Models;

public class Students
{
    public int Id { get; set; }
    public string FirstName { get; set; } 
    public string LastName { get; set; } 
    public int Id_Group { get; set; }
    public int Term { get; set; }
}
