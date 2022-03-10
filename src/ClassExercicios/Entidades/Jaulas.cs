using ClassExercicios.Enumerator;

namespace ClassExercicios.Entidades
{
    public class Jaulas
    {
        public void Jaula()
        {
            foreach (var elemento in Enum.GetValues(typeof(AnimalJaulasEnum)))
            {
                if (elemento.ToString() == "Cachorro")
                {
                    Cachorro bixo = new();
                    Console.WriteLine(" O  animal " + elemento.ToString() + " " + bixo.Som+" e "+bixo.Movimento);
                    continue;
                }
                if (elemento.ToString() == "Cavalo")
                {
                    Cavalo bixo = new();
                    Console.WriteLine(" O  animal " + elemento.ToString() + " " + bixo.Som + " e " + bixo.Movimento);
                    continue;
                }
                if (elemento.ToString() == "Preguica")
                {
                    Preguica bixo = new();
                    Console.WriteLine(" O  animal " + elemento.ToString() + " " + bixo.Som + " e " + bixo.Movimento);
                    continue;
                }
                if (elemento.ToString() == "Cobra")
                {
                    Cobra bixo = new();
                    Console.WriteLine(" O  animal " + elemento.ToString() + " " + bixo.Som + " e " + bixo.Movimento);
                    continue;
                }
                if (elemento.ToString() == "Tubarão")
                {
                    Tubarao bixo = new();
                    Console.WriteLine(" O  animal " + elemento.ToString() + " " + bixo.Som + " e " + bixo.Movimento);
                    continue;
                }
                if (elemento.ToString() == "Macaco")
                {
                    Macaco bixo = new();
                    Console.WriteLine(" O  animal " + elemento.ToString() + " " + bixo.Som + " e " + bixo.Movimento);
                    continue;
                }
                if (elemento.ToString() == "Elefante")
                {
                    Elefante bixo = new();
                    Console.WriteLine(" O  animal " + elemento.ToString() + " " + bixo.Som + " e " + bixo.Movimento);
                    continue;
                }
                if (elemento.ToString() == "Canguru")
                {
                    Canguru bixo = new();
                    Console.WriteLine(" O  animal " + elemento.ToString() + " " + bixo.Som + " e " + bixo.Movimento);
                    continue;
                }
                if (elemento.ToString() == "Papagaio")
                {
                    Papagaio bixo = new();
                    Console.WriteLine(" O  animal " + elemento.ToString() + " " + bixo.Som + " e " + bixo.Movimento);
                    continue;
                }
                if (elemento.ToString() == "Bemtevi")
                {
                    Bemtevi bixo = new();
                    Console.WriteLine(" O  animal " + elemento.ToString() + " " + bixo.Som + " e " + bixo.Movimento);
                    continue;
                }
 

            }
        }
    }
}
