namespace BeerBowling.Domain.Models;

public class Player
{
    public Player()
    {
        
    }

    public Player(int playerId, string name, string nickName, int age)
    {
        PlayerId = playerId;
        Name = name;
        NickName = nickName;
        Age = age;
    }

    public int PlayerId { get; set; }
    public string Name { get; set; }
    public string NickName { get; set; }
    public int Age { get; set; }
}