using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Nokia nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "111111111111111", memoria: 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");
            Console.WriteLine($"Número: {nokia.Numero}, Modelo: {nokia.Modelo}, IMEI: {nokia.Imei}, Memória: {nokia.Memoria}GB\n");

            Console.WriteLine("Smartphone iPhone:");
            Iphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 15 Pro", imei: "222222222222222", memoria: 256);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
            Console.WriteLine($"Número: {iphone.Numero}, Modelo: {iphone.Modelo}, IMEI: {iphone.Imei}, Memória: {iphone.Memoria}GB\n");
        }
    }
}