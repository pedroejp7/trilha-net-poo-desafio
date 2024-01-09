namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando: {nomeApp}");
        }

        public static void TestarIphone(){
            Console.WriteLine("testando Iphone");
            Nokia nokia = new Nokia("987654321", "Iphone", "123123123123123", 128);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Clash of clans");
        }
    }
}