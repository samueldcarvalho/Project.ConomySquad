using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Api.Domain.Entities
{
    public class Usuario : Entity
    {
        public string KeyRefUsuario { get; private set; }
        public string Nome { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public decimal CarteiraUsuario { get; private set; }
        public List<Grupo> Grupos { get; private set; }
        public List<Grupo> GruposLider { get; private set; }
        public List<Interacao> Interacoes;


        //CONSTRUTOR E MÉTODOS PRIMÁRIOS
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
            RetornarKeyRefUsuario();
            this.Nome = nome;
            this.Login = login;
            this.Senha = senha;
            this.Email = email;
        }
        public void RetornarKeyRefUsuario()
        {
            char[] _caracteres = "qwertyuiopasdfghjklzxcvbnm0123456789".ToCharArray();
            Random r = new Random();
            string _randomID = "";

            for (int i = 0; i < 5; i++)
            {
                _randomID += _caracteres[r.Next(0, 35)].ToString();
            }
            KeyRefUsuario = _randomID;
        }

        //MÉTODOS E AÇÕES DO USUÁRIO
        public void Interagir(string tipoInteracao, string descricao, Grupo grupo, decimal valor)
        {
            if (string.IsNullOrWhiteSpace(descricao) || string.IsNullOrEmpty(descricao))
            {
                descricao = null;
            }

            switch (tipoInteracao)
            {
                case "movimento":
                    var interacao1 = new Movimento(descricao, valor, this, grupo);
                    Interacoes.Add(interacao1);
                    grupo.Interacoes.Add(interacao1);
                    break;
                case "comentario":
                    var interacao2 = new Comentario(descricao, this, grupo);
                    Interacoes.Add(interacao2);
                    grupo.Interacoes.Add(interacao2);
                    break;
            }
        }
        public void RemoverInteracao(Grupo grupo, int idInteracao)
        {
            if (Grupos.Any(a => a.Id != grupo.Id))
                throw new Exception($"Você não pode remover uma interação do grupo {grupo.Nome} pois você não é membro.");
            if (grupo.Interacoes.Any(b => b.Id != idInteracao))
                throw new Exception($"A interação {idInteracao} não existe na timeline do grupo {grupo.Id}.");
            if (Interacoes.Any(d => d.Id != idInteracao))
                throw new Exception($"Você não pode remover uma interação que não pertence a você.");

            var tipoInteracao = Interacoes.FirstOrDefault(i => i.Id == idInteracao);
            string strTipoInteracao = "";
            if (tipoInteracao.tipo == Interacao.TipoInteracao.movimento)
                strTipoInteracao = "movimento";
            if (tipoInteracao.tipo == Interacao.TipoInteracao.comentario)
                strTipoInteracao = "comentario";

            switch (strTipoInteracao)
            {
                case "movimento":
                    break;
                case "comentario":
                    break;
            }
            var InteracaoExiste = grupo.Interacoes.FirstOrDefault(c => c.Id == idInteracao);


            grupo.Interacoes.Remove(InteracaoExiste);
            this.Interacoes.Remove(InteracaoExiste);
        }

        //MÉTODOS E AÇÕES : GRUPO
        public void TornarLiderGrupo(Grupo grupo)
        {
            if (grupo.Lideres.Any(u => u.Id == this.Id))
            {
                this.GruposLider.Add(grupo);
            }
        }
        public void AtribuirGrupo(Grupo grupo)
        {
            Grupos.Add(grupo);
            this.TornarLiderGrupo(grupo);
        }
    }
}
