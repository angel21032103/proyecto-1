using System;


namespace proyecto_1
{
    internal class Horarios
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public char Horario { get; set; }

        public Horarios()
        {
        }

        public void MostrarHorarios()
        {
            Console.WriteLine($"Día: {Dia}, Mes: {Mes}, Año: {Año}, Horario: {Horario}");
        }

        public void ElegirHorario(int dia, int mes, int año, char horario)
        {
            Dia = dia;
            Mes = mes;
            Año = año;
            Horario = horario;
        }
    }
}
