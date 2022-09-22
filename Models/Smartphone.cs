namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // protected Smartphone(string numero)
        // {
        //     Numero = numero;
        // }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao(int numero)
        {
            Console.WriteLine($"Recebendo ligação de número {numero}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}