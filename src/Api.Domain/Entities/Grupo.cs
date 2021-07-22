using System;
using System.Collections.Generic;

namespace Api.Domain.Entities
{
    public class Grupo : Entity
    {
        public Guid IDentityGrupo { get; private set; }
        public string Nome { get; private set; }
        public List<Usuario> Usuarios { get; private set; }
        public List<Usuario> Lideres { get; private set; }
        public decimal Meta { get; private set; }

        public Grupo() : base()
        {

        }
        public void AtribuirNovoUsuario(Usuario Usuario)
        {

        }
    }
}
