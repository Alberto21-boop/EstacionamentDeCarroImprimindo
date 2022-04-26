using System;

namespace App2022
{
    internal class Carros
    {
        public string Nome { get; set; } = default!;
        public string Cor { get; set; } = default!;
        public string LetrasDaPlaca { get; set; } = default!;
        public int NumerosDaPlaca { get; set; }
        public int QauntidadeDePortas { get; set; }

        public string NomeDoCarro()
        {
            return Nome;
        }
        public string CorDoCarros()
        {
            return Cor;
        }
        public string PlacaDoCarro()
        {
            return LetrasDaPlaca  + NumerosDaPlaca;
        }
        public int PortasDoCarro()
        {
            return QauntidadeDePortas;
        }
    }
}