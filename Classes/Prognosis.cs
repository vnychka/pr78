using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr78.Classes
{
    public class Prognosis
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]

        public DateTime Date { get; set; }

        public string Time { get; set; }

        public Prognosis() 
        { 

        }
         
        public Prognosis(DateTime date, string time)
        {
            Date = date;
            Time = time;
        }
    }
}
