using System;


namespace proyecto_1
{
    internal class Pedido:Horarios
    {
        public float[] Productos { get; set; }
        public float Total { get; set; }

        public Pedido()
        {
            Productos = new float[0];
            Total = 0; // Inicializa la propiedad Total
        }

        public void MostrarPedido()
        {
            Console.WriteLine("Pedido: ");
            foreach (var item in Productos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total: {Total}");
        }
    }
}
