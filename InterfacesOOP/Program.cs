using InterfacesOOP;

class Program
{
    static void Main(string[] args)
    {
        Worker wr = new Worker("Ivan");
        wr.Info();
        wr.Work();
        ((IStudent)wr).Study();
        ((IBall)wr).Play();
        ((IGuitare)wr).Play();

        
    }
}