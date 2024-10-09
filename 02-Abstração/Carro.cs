namespace _02_Abstração
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        public int Desace {  get; set; }

        public Carro(string marca, string modelo, int velocidade, int desace)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = velocidade;
            Desace = desace;
        }

        public void velocidademx()
        {
            Console.WriteLine($"A velocidade maxima desse carro é {Velocidade}");
        }
        public void Desacelerar()
        {
            Console.WriteLine($"Você precisa desacelerar {Desace}Km/h para estar no limite da via (110Km/h)");
        }
    }
}
