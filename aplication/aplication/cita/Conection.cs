using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace aplication.cita
{
    public class Conection
    {
        [PrimaryKey]
        public int IdUser { get; set; }
        [MaxLength(300)]
        public string NameUser { get; set; }
        [MaxLength(300)]
        public int PhoneUser { get; set; }
        [MaxLength(50)]
        public string SitioUser { get; set; }
        [MaxLength(100)]
        public string DirectionUser { get; set; }
        [MaxLength(50)]
        public string Entrenamiento { get; set; }
        [MaxLength(50)]
        public string DuraEntrena { get; set; }
        [MaxLength(50)]
        public string InicioEntrena { get; set; }
        [MaxLength(10)]
        public int DiaEntrena { get; set; }
        [MaxLength(10)]
        public int MesEntrena { get; set; }
        [MaxLength(10)]
        public int AñoEntrena { get; set; }
    }
}
