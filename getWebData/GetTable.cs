using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getWebData
{
   public  class GetTable
    {
       public GetTable() {
           this.CreateTime = DateTime.Now;
       }
       [Key]
       public int Id { get; set; }
       public string City { get; set; }
       public DateTime Date { get; set; }
       public string QualityRank { get; set; }
       public int AQI { get; set; }
       public int AQIDateRank { get; set; }
       public int PM2 { get; set; }
       public int PM10 { get; set; }
       public int So2 { get; set; }
       public int No2 { get; set; }
       public double Co { get; set; }
       public int O3 { get; set; }
       public DateTime CreateTime { set; get; }
    }
}
