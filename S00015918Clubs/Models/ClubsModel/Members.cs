using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00015918Clubs.Models.ClubsModel
{
    [Table("Member")]
    public class Member
    {   
        [Key,Column(Order =1)]
        public Guid memberID { get; set; }
        [Key, Column(Order = 2)]
        public Guid StudentID { get; set; }
        public bool approved { get; set; }
    }
}