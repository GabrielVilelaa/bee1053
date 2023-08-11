using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        double rombus;
        rombus = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));



        if (rombus <= 2000.00)
        {
            Console.WriteLine("Insento");
        }
        else if  (rombus <= 3000.00)
        {
            double valorTaxavel = rombus - 2000.00;// subtrair o 3002-2000=1002 // OK
            double taxa = 0.08; // 8% de taxa//OK
            double imposto = valorTaxavel * taxa;// 1000.00 * 0.08 = 80 //OK
           
                Console.WriteLine("R$ " + imposto.ToString ("F2", CultureInfo.InvariantCulture));
        }
        // esse bloco esta ok com suas alteracoes 

       else if  (rombus <= 4500.00)
        {
            double valorTaxavel = rombus - 2000.00;// subtrair o 3002-2000=1002 // OK
            double taxa = 0.08; // 8% de taxa
            double imposto = valorTaxavel * taxa;// 1000.00 * 0.08 = 80 
      
                double valornovo = valorTaxavel - 1500.00;// 1002-1000 == 2 reais 
                double novataxa = 0.18;// valor acima de 1000
                double novastaxa = valornovo * novataxa;// 2 * 0.18 = 0.36
                double valoralterado = imposto + novastaxa;
                Console.WriteLine("R$ " + imposto.ToString ("F2", CultureInfo.InvariantCulture));
       
        }
        else  
        {
            double valorTaxavel = rombus - 2000.00;
            double taxa1 = 0.08;
            double imposto1 = 1000.00 * taxa1;
            double taxa2 = 0.18;
            double imposto2 = 1500.00 * taxa2;
            double valorTaxavelRestante = valorTaxavel - 2500.00;
            double taxa3 = 0.28;
            double imposto3 = valorTaxavelRestante * taxa3;
            double impostoTotal = imposto1 + imposto2 + imposto3;
            Console.WriteLine("R$ " + impostoTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

