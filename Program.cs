//etapa de 1 
Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine($" === KIOSCO EL RECREO === .");
Console.WriteLine($"Nombre del cajero: {nombre} .");
Console.WriteLine($"Bienvenida, {nombre}. Caja abierta .");


/*etapa de 2

Console.Write("Ingrese el nombre de producto: ");
string nombreProducto = Console.ReadLine();

Console.Write("Ingrese el precio del producto: ");
decimal precioProducto = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Producto:{nombreProducto}, Precio: {precioProducto}.");
Console.ReadKey();
*/

//etapa 3 

decimal totalVenta = 0m;
int cantidadProductos = 0;
string opcion = "";


const decimal DescuentoAlto = 0.10m; //etapa 4 variables
const decimal DescuentoBajo = 0.05m;//etapa 4 variables 

const decimal DescuentoEfectivo = 0.10m; //etapa 5 variables
const decimal RecargoCredito = 0.15m; //etapa 5 variables

do
{
    Console.WriteLine("Qué desea hacer?");
    Console.WriteLine("1. cargar un producto");
    Console.WriteLine("2. cerrar la venta?");
    Console.WriteLine("Opción :");

    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":

            Console.Write("Ingrese el nombre de producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            decimal precioProducto = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Producto:{nombreProducto}, Precio: {precioProducto}.");

            totalVenta = totalVenta + precioProducto;
            cantidadProductos++;

            break;

        case "2":

            Console.WriteLine("cerrando venta");
            break;

        default:

            Console.WriteLine("comando no reconocido, ingresar 1 o 2.");
            Console.WriteLine();
            break;
    }
} while (opcion != "2");

//etapa 4

decimal descuento = 0m; 

if (totalVenta > 50000m)
{
    descuento = totalVenta * DescuentoAlto;
}
else if (totalVenta > 20000m)
{
    descuento = totalVenta * DescuentoBajo;
}
else
{
    descuento = 0m;
}

decimal totalConDescuento = totalVenta - descuento;

//etapa 5
string medioPago = "";
decimal descuentoPago = 0m;
decimal recargoPago = 0m;
bool medioValido = false;

Console.WriteLine();
do
{
    Console.WriteLine("Medio de pago:");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Débito");
    Console.WriteLine("3 - Crédito");
    Console.Write("Opción: ");
    medioPago = Console.ReadLine();

    switch (medioPago)
    {
       case "1":
            descuentoPago = totalConDescuento * DescuentoEfectivo;
            medioValido = true;
            break;
       
       case "2":
            medioValido = true;
            break;

       case "3":
            recargoPago = totalConDescuento * RecargoCredito;
            medioValido = true;
            break;

        default:
            Console.WriteLine("Medio de pago inválido. Ingrese 1, 2 o 3.");
            Console.WriteLine();
            break;

    }

}while (!medioValido);

decimal totalFinal = totalConDescuento - descuentoPago + recargoPago;
decimal descuentoTotal = descuento + descuentoPago;

Console.WriteLine();
Console.WriteLine($"Cantidad de productos cargados: {cantidadProductos}");
Console.WriteLine($"Total sin decscuentos: ${totalVenta}");
Console.WriteLine($"Descuento aplicado: ${descuentoTotal}");
Console.WriteLine($"Recargo aplicado: ${recargoPago}");
Console.WriteLine($"Total final: ${totalFinal}");
Console.ReadKey();

