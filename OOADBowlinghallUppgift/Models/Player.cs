namespace OOADBowlinghallUppgift.Models
{
    public class Player // klassför spelare med namn och medlemsnummer
    {
        public string Name { get; set; }
        public int MemberNumber { get; set; }

        public Player(string name, int memberNumber)
        {
            Name = name;
            MemberNumber = memberNumber;
        }
    }
}
