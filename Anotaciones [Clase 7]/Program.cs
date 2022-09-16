using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
		int numero1 = 10;
		int numero2 = 20;
		int suma = numero1 + numero2;
		int division;

		try
		{
			//int num = int.Parse("xxx");
			division = suma / 0;
		}
		catch (FormatException ex)
		{
			Console.WriteLine($"Format exception {ex.Message}");
		}
		catch(OverflowException)
		{
            Console.WriteLine("overflow exception");
        }
		catch(DivideByZeroException)
		{
			Console.WriteLine("Error, intentaste dividir por 0");
		}

		// No se ejecuta mas de un catch
    }
}