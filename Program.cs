using System;

namespace C_
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Indorme o valor em R$: ");
      string valorDigitado = Console.ReadLine();
      decimal valorConvertido = 0.0m, valorCambio = 0.1932m;

      decimal.TryParse(valorDigitado, out valorConvertido);

      decimal valorCambioConvertido = valorConvertido * valorCambio;

      Console.WriteLine($"valor em $: {valorCambioConvertido}");
      Console.ReadLine();
    }
  }
}