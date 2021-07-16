using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Uid {get;set;}
        public string Email { get; set; }
        
    }
}
