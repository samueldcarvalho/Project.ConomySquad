using System;

namespace Api.Domain.Entities
{
    public class Movimento : Interacao
    {
        public decimal Valor { get; private set; }
        public Movimento(string Descricao, decimal Valor, Usuario usuarioResp, Grupo grupo)
        {
            this.tipo = TipoInteracao.movimento;

            if (Valor == 0)
                throw new Exception("O valor não pode ser zerado. Deve ser positivo ou negativo.");
            if (Descricao.Length > 300)
                throw new Exception("A descrição do movimento não pode possuir mais de 300 caracteres.");
            if (usuarioResp == null)
                throw new Exception("O usuário não foi informado no momento da gravação.");
            if (grupo == null)
                throw new Exception("O grupo não foi informado no momento da gravação.");

            this.Valor = Valor;
            this.Descricao = Descricao;
            this.UsuarioResponsavel = usuarioResp;
            this.Grupo = grupo;
        }
    }
}
