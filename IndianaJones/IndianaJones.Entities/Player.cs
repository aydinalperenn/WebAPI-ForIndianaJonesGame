using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IndianaJones.Entities
{
    public class Player
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }


        [Range(0, int.MaxValue)] // Olası değer aralığını belirleyebilirim
        public int Score { get; set; }



    }
}