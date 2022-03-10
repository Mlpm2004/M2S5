using ClassExercicios.Enumerator;

namespace ClassExercicios.Entidades
{
    public class CriaAnimal
    {
        public void CriaAnimais()
        {
            foreach (var elemento in Enum.GetValues(typeof(AnimalEnum)))
            {
                if (elemento.ToString()== "Cachorro"){
                    Cachorro bixo = new ();
                    Console.WriteLine(" O  " + elemento.ToString() + " " + bixo.Som);
                    continue;
                }
                if (elemento.ToString() == "Cavalo")
                {
                    Cavalo bixo = new();
                    Console.WriteLine(" O  " + elemento.ToString() + " " + bixo.Som);
                    continue;
                }
                if (elemento.ToString() == "Preguica")
                {
                    Preguica bixo = new();
                    Console.WriteLine(" O  " + elemento.ToString() + " " + bixo.Som);
                    continue;
                }


            }
        }
    }
}
