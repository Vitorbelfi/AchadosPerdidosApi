﻿namespace Api.Models
{
    public class ObservacoesModel
    {
        public int ObservacaoId { get; set; }

        public string ObservacaoDescricao { get; set; } = string.Empty;

        public string ObservacaoLocal { get; set; } = string.Empty;

        public string ObservacaoData { get; set; } = string.Empty;


        public static implicit operator List<object>(ObservacoesModel v)
        {
            throw new NotImplementedException();
        }
    }
}
