namespace DesafioPOO.Models
{
public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            base.Numero = numero;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"\nInstalado o aplicativo {nomeApp} no Nokia!");
        }
    }
}