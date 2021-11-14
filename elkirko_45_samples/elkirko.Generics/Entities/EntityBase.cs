
using System.ComponentModel.DataAnnotations;
namespace elkirko.Generics.Entities
{
    public class EntityBase : elkirko.Generics.Entities.IEntity
    {
        [Key]
        public int Id { get; set; }
    }

}
