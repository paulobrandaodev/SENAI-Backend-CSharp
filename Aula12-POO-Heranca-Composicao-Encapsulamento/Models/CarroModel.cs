namespace Aula12_POO_Heranca_Composicao_Encapsulamento.Models
{
    public class CarroModel
    {
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public string Cor {get; set;}
        public string Placa {get; set;}
        public bool Ligado {get; set;}
        
        // COMPOSIÇÃO
        public MotorModel Motor {get; set;}
    }
}