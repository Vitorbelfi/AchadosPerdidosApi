﻿namespace Api.Models
{
    public class AnimaisModel
    {
        public int AnimalId { get; set; }

        public string AnimalNome { get; set; } = string.Empty;

        public string AnimalRaca { get; set; } = string.Empty;

        public string AnimalTipo { get; set; } = string.Empty;

        public string AnimalCor { get; set; } = string.Empty;

        public string AnimalSexo { get; set; } = string.Empty;

        public string AnimalObservacao { get; set; } = string.Empty;

        public string AnimalFoto { get; set; } = string.Empty;

        public string AnimalDtDesaparecimento { get; set; } = string.Empty;

        public string AnimalDtEncontro { get; set; } = string.Empty;

        public string AnimalStatus { get; set; } = string.Empty;

        


        public static implicit operator List<object>(AnimaisModel v)
        {
            throw new NotImplementedException();
        }
    }
}
