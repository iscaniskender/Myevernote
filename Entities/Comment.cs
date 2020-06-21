using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.Entities
{
    [Table("comments")]
    public class Comment : MyEntitiesBase
    {
        [Required]
        public string Text { get; set; }


        public virtual Note Note { get; set; }
        public virtual EvernoteUser Owner { get; set; }
      
}
    
}
