using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace aplication.Models
{
    public class Conection
    {
        [PrimaryKey] 
        public int IdUser { get; set; }
        [MaxLength(300)]
        public string NameUser { get; set; }
        [MaxLength(300)]
        public string EmailUser { get; set; }
        [MaxLength(50)]
        public string PasswordUser { get; set; }
    }
}
