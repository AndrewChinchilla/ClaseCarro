using ClaseCarro;


Carro Carrito = new Carro("Mitsubishi", 2020, "NEGRO", 180);

String mensaje;

Console.WriteLine("\n");
Console.WriteLine(Carrito.DameInformacion());
Console.WriteLine("\n");

Carrito.EncenderMotor();

Console.WriteLine("\n");
Carrito.Claxón();

Console.WriteLine("\n");
Carrito.acelerar();
Carrito.acelerar();
Carrito.acelerar();
Carrito.acelerar();
Carrito.acelerar();
Carrito.acelerar();
Carrito.acelerar();

Console.WriteLine("\n");
Carrito.Desacelerar();
Carrito.Desacelerar();
Carrito.Desacelerar();

Console.WriteLine("\n");
Carrito.FrenadoNormal();

Console.WriteLine("\n");
Console.WriteLine(Carrito.GetVelocidadActual());


Console.WriteLine("\n");
Carrito.Claxón();

Console.WriteLine("\n");
Carrito.Frenado_total();

Console.WriteLine("\n");
Console.WriteLine(Carrito.GetVelocidadActual());

Console.WriteLine("\n");
Carrito.ApagarMotor();









