namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private readonly string _modelo;
        private readonly string _IMEI;
        private readonly int _memoria;

        public Smartphone(string numero, string IMEI, int memoria, string modelo)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            _memoria = memoria;
            _IMEI = IMEI;
            _modelo = modelo;
        }

        public void Ligar()
        {
            Console.WriteLine($"{_modelo} - Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{_modelo} - Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}