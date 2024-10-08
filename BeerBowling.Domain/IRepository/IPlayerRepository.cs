using BeerBowling.Domain.Models;

namespace BeerBowling.Domain.IRepository;

public interface IPlayerRepository
{
    Player GetPlayerByIdAsync(int playerId);
    ICollection<Player> GetAllPlayers();
}