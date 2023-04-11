int numero;
do
{
    Console.WriteLine("1.Cargar Datos Boxeador 1");
    Console.WriteLine("2.Cargar Datos Boxeador 2");
    Console.WriteLine("3.Pelear");
    Console.WriteLine("4. Salir");
    numero = ingresarNumero("Ingrese un numero para seleccionar alguna de las opciones de arriba");
    switch(numero)
    {
        case 1:
        Boxeador boxeador1 = cargarDatosBoxeador();
        break;
        case 2:
        Boxeador boxeador2 = cargarDatosBoxeador();
        break;
    }
} while (numero != 4);
int ingresarNumero(string msj)
{
    int devolver;
    Console.WriteLine(msj);
    devolver = int.Parse(Console.ReadLine());
    while(devolver < 1 && devolver > 4 )
    {
        Console.WriteLine("Error, numero mal ingresado, volve a ingresarlo");
        Console.WriteLine(msj);
        devolver = int.Parse(Console.ReadLine());
    }
    return devolver;
}
Boxeador cargarDatosBoxeador()
{
    string nombre = ingresarTexto("Ingrese su nombre");
    string pais = ingresarTexto("Ingrese su pais de nacimiento");
    double peso = ingresarPeso("Ingrese su peso");
    int potenciaGolpes = ingresarNum("Ingrese la potencia de su golpe, tiene que ser entre 1 y 100");
    int velocidadPiernas = ingresarNum("Ingrese la velocidad de sus piernas, tiene que ser entre 1 y 100");
    Boxeador boxeador = new Boxeador(nombre, pais, peso, potenciaGolpes, velocidadPiernas);
    Console.WriteLine("Se ha creado el boxeador: " + nombre);
    return boxeador;
}
string ingresarTexto(string msj)
{
    string text;
    Console.WriteLine(msj);
    text = Console.ReadLine();
    return text;
}
int ingresarNum(string msj)
{
    int devolver;
    Console.WriteLine(msj);
    devolver = int.Parse(Console.ReadLine());
    while(devolver < 1 && devolver > 100)
    {
        Console.WriteLine("Ingresaste mal los datos, volve a hacerlo");
        Console.WriteLine(msj);
        devolver = int.Parse(Console.ReadLine());
    }
    return devolver;
}
double ingresarPeso(string msj)
{
    double peso;
    Console.WriteLine(msj);
    peso = double.Parse(Console.ReadLine());
    return peso;
}