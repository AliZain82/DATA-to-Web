using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AZ_datapage.Models
{
    public class DataModel
    {

        
            [Key]
            public int GameID { get; set; }
            [Column(TypeName = "Varchar(20)")]
            public string GameName { get; set; }
            [Column(TypeName = "Varchar(20)")]
            public string Address { get; set; }

        
    }
}
