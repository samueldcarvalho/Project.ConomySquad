using System;

namespace Api.Domain.Entities
{
    public class Comentario : Interacao
    {
        public Comentario(string Descricao, Usuario usuarioResp, Grupo grupo)
        {
            this.tipo = TipoInteracao.comentario;

            if (Descricao.Length > 600)
                throw new Exception("O comentário não pode possuir mais de 600 caracteres.");
            if (usuarioResp == null)
                throw new Exception("O usuário não foi informado no momento da gravação.");
            if (grupo == null)
                throw new Exception("O grupo não foi informado no momento da gravação.");

            this.Descricao = Descricao;
            this.UsuarioResponsavel = usuarioResp;
            this.Grupo = grupo;
        }
    }
}
