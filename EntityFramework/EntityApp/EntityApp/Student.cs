using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace EntityApp
{
    [Table ("STUDENT")]
    public class Student
    {
        [Key]
        public Guid ID
        {
            get;
            set;
        }
        public string NAME { get; set; }
        public float CGPI { get; set; }
        public string LOC { get; set; }
        public int AGE { get; set; }
    }
}
