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

            string noise = "RIBBBBBBBIT";
            Frog frogger = new Frog(noise);
            frogger.Move();
            frogger.Sleep();

        }
    }
    
}