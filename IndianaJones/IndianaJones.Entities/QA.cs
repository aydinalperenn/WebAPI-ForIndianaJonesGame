using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianaJones.Entities
{
    public class QA
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }


        [StringLength(300)]
        public string Question { get; set; }


        [Range(0, int.MaxValue)] // Olası değer aralığını belirleyebilirim
        public int AnswerNum { get; set; }


        [StringLength(200)]
        public string AnswerDescribe { get; set; }


        [Range(0, int.MaxValue)] // Olası değer aralığını belirleyebilirim
        public int QALevel { get; set; }


        [StringLength(1)]
        public string Situation { get; set; }

    }
}
