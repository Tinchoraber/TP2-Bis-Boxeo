class Boxeador
{
    public string Nombre{get;set;}
    public string Pais{get;set;}
    public double Peso{get;set;}
    public int PotenciaGolpes{get;set;}
    public int VelocidadPiernas{get;set;}
    public Boxeador(string nombre, string pais, double peso, int potenciaGolpes, int velocidadPiernas)
    {
        Nombre = nombre;
        Pais = pais;
        Peso = peso;
        PotenciaGolpes = potenciaGolpes;
        VelocidadPiernas = velocidadPiernas;
    }
}