namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        protected string Modelo;

        protected string Imei;

        protected int Memoria;

        public Smartphone(string numero)
        {
            Numero = numero;
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void DetalhesSmartphone()
        {
            Console.WriteLine($"Smartphone modelo: {Modelo}, imei: {Imei}, memoria: {Memoria} e numero: {Numero}.");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}