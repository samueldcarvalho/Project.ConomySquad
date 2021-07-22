using System;
using System.Collections.Generic;

namespace Api.Domain.Entities
{
    public class Grupo : Entity
    {
        public string KeyRefGrupo { get; private set; }
        public string Nome { get; private set; }
        public decimal CarteiraGrupo { get; private set; }
        public List<Usuario> Usuarios { get; private set; }
        public List<Usuario> Lideres { get; private set; }
        public List<Interacao> Interacoes { get; set; }
        public decimal Meta { get; private set; }

        public Grupo()
        {

        }
    }
}
