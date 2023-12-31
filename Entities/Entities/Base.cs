﻿using Entities.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Entities.Entities
{
    public abstract class Base : Notify
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
