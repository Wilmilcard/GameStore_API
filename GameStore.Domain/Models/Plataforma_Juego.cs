﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Models
{
    public class Plataforma_Juego : IAuditEntity
    {
        public int Id_Juego { get; set; }
        public int Id_Plataforma { get; set; }


        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [StringLength(50)]
        [Column(TypeName = "VARCHAR(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string CreatedBy { get; set; }
    }
}