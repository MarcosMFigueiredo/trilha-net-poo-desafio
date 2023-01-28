namespace DesafioPOO.Models
{
    public class Iphone: Smartphone
    {
        
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        public override void IntalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} da Apple Store");
        }
    }
}