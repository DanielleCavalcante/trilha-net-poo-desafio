namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; protected set; } //set nas classes filhas
        protected string Modelo { get; } //somente leituras
        protected string IMEI { get; }
        protected int Memoria { get; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            
            if (string.IsNullOrEmpty(numero))
            {
                throw new ArgumentException("Número não pode ser vazio.", nameof(numero)); //(Parameter 'numero')
            }

            if (string.IsNullOrEmpty(modelo))
            {
                throw new ArgumentException("Modelo não pode ser vazio.", nameof(modelo));
            }

            if (string.IsNullOrEmpty(imei))
            {
                throw new ArgumentException("IMEI não pode ser vazio.", nameof(imei));
            }

            if (memoria < 0)
            {
                throw new ArgumentException("Memória deve ser maior que 0.", nameof(memoria));
            }
            
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("\nLigando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("\nRecebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nNúmero: {Numero}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memória: {Memoria} GB");
        }
    }
}