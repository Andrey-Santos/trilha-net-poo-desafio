namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria): base(numero, modelo, imei, memoria)
        {
            // Construtor do iPhone chama o construtor da classe base (Smartphone)
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone.");
        }
    }
}