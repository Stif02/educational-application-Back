using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace WebApi.Models

{
    
    public class QSelectOutOfFour
    {
        [Key]
        public int ID { get; set; }
        public string task { get; set; }
        public string answerString { get; set; }
        public string variant1 { get; set; }
        public string variant2 { get; set; }
        public string variant3 { get; set; }
        public string variant4 { get; set; }

       
    }
}
