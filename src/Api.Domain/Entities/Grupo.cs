using System;

namespace Api.Domain.Entities
{
    public class Grupo : Entity
    {
        public Guid IDentityGrupo { get; private set; }
        public string Nome { get; private set; }
        public Usuario[] Usuarios { get; private set; }
        public Usuario Lider { get; private set; }
        public decimal Meta { get; private set; }

        public Grupo() : base()
        {

        }
        public void AtribuirNovoUsuario(Usuario Usuario)
        {

        }
    }
}
