using System;

namespace Api.Domain.Entities
{
    public class Movimento : Entity
    {
        public string IDUsuarioResponsavel { get; private set; }
        public decimal Valor { get; private set; }
        public string Descricao { get; set; }
        public Movimento(string Descricao, decimal Valor, string idUsuarioResp)
        {
            if (Descricao.Length > 300)
                throw new Exception("A descrição não pode possuir mais de 300 caracteres.");
            if (Valor == 0)
                throw new Exception("O valor não pode ser zerado. Deve ser positivo ou negativo.");
            if (string.IsNullOrEmpty(idUsuarioResp))
                throw new Exception("O usuário não foi informado no momento da gravação.");

            this.Descricao = Descricao;
            this.Valor = Valor;
            this.IDUsuarioResponsavel = idUsuarioResp;
        }
    }
}
