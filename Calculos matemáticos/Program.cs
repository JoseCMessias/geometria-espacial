using formas_geométrica;

class Program
{
    static void Main(string[] args)
    {
        CalculoVolume calculoVolume = new CalculoVolume();

        try
        {
            Console.WriteLine("\n1 - Esfera \n2 - Cubo \n3 - Paralelepido \n4 - Cone \n5 - Cilindro \n6 - Pirâmide");
            Console.Write("Informe a opção numerada: ");
            int opcao = int.Parse(Console.ReadLine());
              
            switch (opcao)
            {
                case 1:
                    calculoVolume.esfera();
                    break;
                case 2:
                    calculoVolume.cubo();
                    break;
                case 3:
                    calculoVolume.paralelepido();
                    break;
                case 4:
                    calculoVolume.cone();
                    break;
                case 5:
                    calculoVolume.cilindro();
                    break;
                case 6:
                    calculoVolume.piramide();
                    break;
                default:
                    Console.WriteLine("Informe valores válidos!");
                break;
            }   
        }
        catch (Exception)
        {
            Console.WriteLine("Informe valores válidos!");
        }
    }
}
