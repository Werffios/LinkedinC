namespace Agencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Agencia de Vehiculos";
            Console.WriteLine("Bienvenido a la Agencia de Vehiculos");
            Console.WriteLine("Seleccione una opcion de captura");
            Console.WriteLine("1. Moto");
            Console.WriteLine("2. Automovil");
            Console.WriteLine("3. Camioneta");
            Console.WriteLine("4. Salir");
            Console.Write("Opcion: ");

            try
            {
                int opcion = int.Parse(Console.ReadLine());
                int anio, llantas, color;
                string modelo;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Moto");
                        break;
                    case 2:
                        Console.WriteLine("Automovil");
                        Console.Write("Ingrese el modelo del vehiculo: ");
                        modelo = Console.ReadLine();
                        try
                        {
                            Console.Write("Ingrese el año del vehiculo: ");
                            anio = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el numero de llantas del vehiculo: ");
                            llantas = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el color (1- Blanco, 2- Gris, 3- Rojo...): ");
                            color = int.Parse(Console.ReadLine());
                            Automovil auto = new Automovil();
                            auto.Id = 1;
                            auto.Llantas = llantas;
                            auto.Anio = anio;
                            auto.Modelo = modelo;
                            auto.Color = color;
                            auto.Estado = 1;
                            string resultado = auto.Capturar();
                            Console.WriteLine("El vehiculo de " + auto.Id + " fue " + resultado);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Opcion no valida");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Camioneta");
                        break;
                    case 4:
                        Console.WriteLine("Salir");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Opcion no valida");
            }

            Console.ReadKey();
        }
    }
}
