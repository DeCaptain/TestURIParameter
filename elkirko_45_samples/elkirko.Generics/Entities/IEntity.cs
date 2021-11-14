using System;
using System.ComponentModel.DataAnnotations;

namespace elkirko.Generics.Entities
{
    public interface IEntity
    {
        [Key]
        int Id { get; set; }
    }
}
