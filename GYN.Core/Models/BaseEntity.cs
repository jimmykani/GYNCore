using System;
using GYN.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GYN.Core.Models
{
    public abstract class BaseEntity  : IEntity
    {
        [Key]
        public int Id { get; set; }
    }

}
