using System;


namespace proyecto_1
{
    internal class Contabilidad:Cierre
    {
        public float CostoTotal { get; set; }

        public Contabilidad()
        {
        }

        public void CalcularCostoTotal()
        {
            CostoTotal = Total * Productos.Length;
        }

        public void MostrarContabilidad()
        {
            Console.WriteLine($"Costo Total: {CostoTotal}");
        }
    }
}
