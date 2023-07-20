namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Monkey monkey = new Monkey();
            monkey.Sleep();
            monkey.Move();

            Godzilla godzilla = new Godzilla();
            godzilla.Sound();

           
            Frog frogger = new Frog();
            frogger.Move();
            frogger.Sleep();

        }
    }
    
}