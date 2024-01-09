namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando: {nomeApp}");
        }

        public static void TestarNokia()
        {
            Console.WriteLine("testando Nokia");
            Nokia nokia = new Nokia("123456789", "Nokia", "123123123123123", 32);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Elsa Speak");
        }
    }
}