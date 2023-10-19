using System;


namespace proyecto_1
{
    internal class Inventario:Contabilidad
    {
        public int[] ListaInventario { get; set; }

        public Inventario()
        {
            ListaInventario = new int[0];
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Inventario: ");
            foreach (var item in ListaInventario)
            {
                Console.WriteLine(item);
            }
        }
    }
}

