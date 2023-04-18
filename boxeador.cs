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
    public Boxeador()
    {
        
    }
    public double obtenerSkill()
    {
        Random num = new Random();
        double numero = num.Next(1, 10);
        double skill = 0;
        skill = numero + VelocidadPiernas/10 * 6 + PotenciaGolpes /10 * 6;
        return skill;
    }
}