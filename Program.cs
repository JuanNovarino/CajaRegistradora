//etapa de 1 
Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine($" === KIOSCO EL RECREO === .");
Console.WriteLine($"Nombre del cajero: {nombre} .");
Console.WriteLine($"Bienvenida, {nombre}. Caja abierta .");
Console.ReadKey();

//etapa de 2

Console.Write("Ingrese el nombre de producto: ");
string nombreProducto = Console.ReadLine();

Console.Write("Ingrese el precio del producto: ");
decimal precioProducto = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Producto:{nombreProducto}, Precio: {precioProducto}.");
Console.ReadKey();
