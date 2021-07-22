using System;

namespace Api.Domain.Entities
{
    public abstract class Interacao : Entity
    {
        protected Usuario UsuarioResponsavel { get; set; }
        protected Grupo Grupo { get; set; }
        public string Descricao { get; set; }
        public enum TipoInteracao
        {
            movimento,
            comentario
        }
        public TipoInteracao tipo;
    }
}
