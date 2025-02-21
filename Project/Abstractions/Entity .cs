﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Abstractions
{
    public abstract class Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
