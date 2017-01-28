using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdobeApp.Models
{
    [Table("Games")]
    public class Games
    {

        [Key]
        public int GameID { get; set; }
        public DateTime DatePlayed { get; set; }
        public int Challenger { get; set; }
        public int Challenged { get; set; }
        public bool Accepted { get; set; }
        public string Message { get; set; }
        public int WinnerID { get; set; }
        public int LoserID { get; set; }
        public int ReporterID {get; set;}
        
    }
}