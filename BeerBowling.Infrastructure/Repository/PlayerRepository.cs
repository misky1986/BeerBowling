using BeerBowling.Domain.IRepository;
using BeerBowling.Domain.Models;

namespace BeerBowling.Infrastructure.Repository;

public class PlayerRepository : IPlayerRepository
{
    private static readonly List<Player> players =
    [
        new Player(playerId: 1, name: "Michael", nickName: "Skylle", age: 38),
        new Player(playerId: 2, name: "Martin", nickName: "Jønne", age: 38),
        new Player(playerId: 3, name: "Jesper", nickName: "Patte", age: 38)
    ];


    public Player GetPlayerByIdAsync(int playerId)
    {
        return players.SingleOrDefault(p => p.PlayerId == playerId) ?? throw new InvalidOperationException();
    }

    public ICollection<Player> GetAllPlayers()
    {
        return players;
    }
    
}