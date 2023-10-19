using System;


namespace proyecto_1
{
    internal class Cierre:Pedido
    {
        public float Ventas { get; set; }
        public float Ganancia { get; set; }

        public Cierre()
        {
        }

        public void CalcularGanancia()
        {
            Ganancia = Ventas - (Total * Productos.Length);
        }

        public void MostrarVentas()
        {
            Console.WriteLine($"Ventas: {Ventas}");
            Console.WriteLine($"Ganancia: {Ganancia}");
        }
    }
}
