Console.WriteLine("SISTEMA DE CONTROL DE MOTORES");
Console.WriteLine();

// Crear un objeto de la clase Motor
Motor motor1 = new Motor();

// Capturar la información del objeto
Console.Write("Ingrese el identificador del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin ID";

Console.Write("Ingrese la temperatura (°C): ");
motor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente (A): ");
motor1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad (RPM): ");
motor1.Velocidad = Convert.ToDouble(Console.ReadLine());

Console.Write("¿El motor está en marcha? (si/no): ");
motor1.EstadoMarcha = Console.ReadLine() ?? "no";

// Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Motor: {motor1.Identificador}");
Console.WriteLine($"Temperatura: {motor1.Temperatura} °C");
Console.WriteLine($"Corriente: {motor1.Corriente} A");
Console.WriteLine($"Velocidad: {motor1.Velocidad} RPM");
Console.WriteLine($"Alerta de Temperatura: {motor1.DeterminarTemperatura()}");
Console.WriteLine($"Estado de Marcha: {motor1.ObtenerEstadoMarcha()}");


// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";

    public double Temperatura { get; set; }

    public double Corriente { get; set; }

    public double Velocidad { get; set; }

    public string EstadoMarcha { get; set; } = "";


    // Método para determinar si la temperatura es mayor que 70 °C
    public string DeterminarTemperatura()
    {
        if (Temperatura > 70)
        {
            return "TEMPERATURA MAYOR A 70 °C (ALERTA)";
        }
        else
        {
            return "TEMPERATURA NORMAL";
        }
    }


    // Método para determinar si está detenido o en marcha
    public string ObtenerEstadoMarcha()
    {
        if (EstadoMarcha.ToLower() == "si")
        {
            return "EN MARCHA";
        }
        else
        {
            return "DETENIDO";
        }
    }
}