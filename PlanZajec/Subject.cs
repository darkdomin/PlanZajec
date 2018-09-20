using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace PlanZajec
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectDescription { get; set; }
        public int Statystyka {get;set;}
    }
}
