namespace OOADBowlinghallUppgift.Models
{
    public static class PlayerFactory // Factory Pattern används för att skapa spelare på ett strukturerat sätt.

    {
        public static Player CreatePlayer(string name, int memberNumber)
        {
            return new Player(name, memberNumber);
        }
    }
}

