using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
        
        private DateTime? _dataCriacao;
        public DateTime? DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = (value == null ? DateTime.UtcNow : value); }
        }
        public DateTime? DataAtualizacao { get; set; }
    }
}
