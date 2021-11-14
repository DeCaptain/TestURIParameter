

using System.ComponentModel.DataAnnotations;

namespace elkirko.Generics.Entities
{
    public class Employee : EntityBase 
    {
       
        public string FirstName { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + ", FirstName: " + FirstName ;
        }

    }

  }
