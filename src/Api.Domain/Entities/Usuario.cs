using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Api.Domain.Entities
{
    public class Usuario : Entity
    {
        public Guid IDentityUsuario { get; private set; }
        public string Nome { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public List<Grupo> Grupos { get; private set; }
        public List<Grupo> GruposLider { get; private set; }


        public Usuario(string nome, string login, string senha, string email, string IDGrupo)
        {
            if (String.IsNullOrEmpty(nome) || String.IsNullOrWhiteSpace(nome))
                throw new Exception("Digite um nome para continuar.");
            if (nome.Length > 30)
                throw new Exception("O seu nome é muito grande. Insira um apelido. ");
            if (String.IsNullOrWhiteSpace(login) || String.IsNullOrEmpty(login))
                throw new Exception("Insira um usuário para continuar.");
            if (login.Length < 4)
                throw new Exception("Não é permitido o usuário com menos de 4 caracteres.");
            if (Senha.Length < 8)
                throw new Exception($"Senha fraca.{Environment.NewLine}" +
                                    $"- Mínimo de 8 caracteres.{Environment.NewLine}" +
                                    $"- Usar pelo menos uma letra maiúscula e minúscula. [A-Z,a-z]{Environment.NewLine}" +
                                    $"- Usar pelo menos um número. [0-9]{Environment.NewLine}" +
                                    $"- Permitido utilização de símbolos. [$#%!@]");
            if (string.IsNullOrEmpty(IDGrupo) || string.IsNullOrWhiteSpace(IDGrupo))
                throw new Exception("Grupo não informado.");

            ///SETS
            this.Nome = nome;
            this.Login = login;
            this.Senha = senha;
            this.Email = email;
        }


        public void TornarLider(Grupo grupo)
        {
            if (grupo.Lideres.Any(u => u.Id == this.Id))
            {
                GruposLider.Add(grupo);
            }
        }
        public void AtribuirGrupo(Grupo grupo)
        {
            Grupos.Add(grupo);
            this.TornarLider(grupo);
        }
    }
}
