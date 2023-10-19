using System;


namespace proyecto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Horarios
            Horarios horario = new Horarios();
            horario.ElegirHorario(18, 10, 2023, 'A');
            Console.WriteLine("Información de Horarios:");
            horario.MostrarHorarios();

            // Crear una instancia de Pedido
            Pedido pedido = new Pedido();
            pedido.Productos = new float[] { 10.5f, 8.75f, 5.2f };
            pedido.Total = 24.45f;
            Console.WriteLine("\nInformación del Pedido:");
            pedido.MostrarPedido();

            // Crear una instancia de Cierre
            Cierre cierre = new Cierre();
            cierre.Ventas = 100.0f;
            cierre.CalcularGanancia();
            Console.WriteLine("\nInformación del Cierre:");
            cierre.MostrarVentas();

            // Crear una instancia de Contabilidad
            Contabilidad contabilidad = new Contabilidad();
            contabilidad.Total = 50.0f;
            contabilidad.CalcularCostoTotal();
            Console.WriteLine("\nInformación de Contabilidad:");
            contabilidad.MostrarContabilidad();

            // Crear una instancia de Inventario
            Inventario inventario = new Inventario();
            inventario.ListaInventario = new int[] { 10, 20, 30, 40 };
            Console.WriteLine("\nInformación del Inventario:");
            inventario.MostrarInventario();

            Console.Read(  );
        }
    }
}
