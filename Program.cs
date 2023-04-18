int numero;
Boxeador boxeador1 = new Boxeador();
Boxeador boxeador2 = new Boxeador();
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
            boxeador1 = cargarDatosBoxeador();
            break;
        case 2:
            boxeador2 = cargarDatosBoxeador();
            break;
        case 3:
            Pelear();
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
void Pelear()
{
    if (boxeador1.Nombre == "" || boxeador2.Nombre == "")
    {
        Console.WriteLine("No existe el boxeador, tenes que volver a cargarlo");
    }
    else
    {
        calcularGanador();
    }
}
void calcularGanador()
{
    if(boxeador1.obtenerSkill() > boxeador2.obtenerSkill())
    {
        if(boxeador1.obtenerSkill() - boxeador2.obtenerSkill() >= 30)
        {
            Console.WriteLine("El ganador del combate es " + boxeador1.Nombre + " por KO");
        }
        else if(boxeador1.obtenerSkill() - boxeador2.obtenerSkill() >= 10 && boxeador1.obtenerSkill() - boxeador2.obtenerSkill() < 30)
        {
            Console.WriteLine("El ganador del combate es " + boxeador1.Nombre + " por puntos en fallo unanime");
        }
        else
        {
            Console.WriteLine("El ganador del combate es " + boxeador1.Nombre + " por puntos en fallo dividido");
        }
    }
    else
    {
        if(boxeador2.obtenerSkill() - boxeador1.obtenerSkill() >= 30)
        {
            Console.WriteLine("El ganador del combate es " + boxeador2.Nombre + " por KO");
        }
        else if(boxeador2.obtenerSkill() - boxeador1.obtenerSkill() >= 10 && boxeador2.obtenerSkill() - boxeador1.obtenerSkill() < 30)
        {
            Console.WriteLine("El ganador del combate es " + boxeador2.Nombre + " por puntos en fallo unanime");
        }
        else
        {
            Console.WriteLine("El ganador del combate es " + boxeador2.Nombre + " por puntos en fallo dividido");
        }
    }
}