using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlServer.Model
{
    [Table(name: "Role")]
    class UserRole
    {
      
        Int32 roleId;
        String role;

        public virtual ICollection<User> users { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "id")]
        public int RoleId { get => roleId; set => roleId = value; }

        public string Role { get => role; set => role = value; }
    }
}
