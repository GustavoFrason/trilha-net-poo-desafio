namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string IMEI, int memoria) : base(numero)
        {

            Console.WriteLine($"As caracteristicas do aparelho é: {modelo}, numero: {numero}, imei: {IMEI}, memoria: {memoria}");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(nomeApp + "aplicativo instalado com sucesso no nokia.");
        }
    }
}