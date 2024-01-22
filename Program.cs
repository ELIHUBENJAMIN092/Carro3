
    using Carro3;


    class Program { 
    static void Main()
    {
        Automovil miAutomovil = new Automovil();
        miAutomovil.Marca = "Volkswagen";
        miAutomovil.Modelo = "Gol";
        miAutomovil.Año = 2017;
        miAutomovil.Puertas = 5;

        Camioneta miCamioneta = new Camioneta();
        miCamioneta.Marca = "Chevrolet";
        miCamioneta.Modelo = "Dimax";
        miCamioneta.Año = 2024;
        miCamioneta.CapacidadCarga = 6;

        miAutomovil.getInformation();
        miAutomovil.runAction();

        Console.WriteLine();

        miCamioneta.getInformation();
        miCamioneta.runAction();
    }
}