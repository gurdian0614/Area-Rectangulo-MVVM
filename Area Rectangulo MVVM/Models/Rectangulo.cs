
namespace Area_Rectangulo_MVVM.Models
{
    internal class Rectangulo
    {
        public double Base { get; set;}
        
        public double Altura { get; set;}
        
        public double Calcular()
        {
            return Base * Altura;
        }
    }
}
