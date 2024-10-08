using BeerBowling.Domain.IRepository;
using BeerBowling.Domain.Models;
using Microsoft.Extensions.Caching.Memory;

namespace BeerBowling.Infrastructure.Repository;

public class CachedPlayerRepository : IPlayerRepository
{
    private readonly IPlayerRepository _decorated;
    private readonly IMemoryCache _memoryCache;
    
    public CachedPlayerRepository(IPlayerRepository decorated, IMemoryCache memoryCache)
    {
        _decorated = decorated;
        _memoryCache = memoryCache;
    }

    public Player? GetPlayerByIdAsync(int playerId)
    {
        string key = $"player-{playerId}";

        return _memoryCache.GetOrCreate(
            key,
            entry =>
            {
                entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(2));
                return _decorated.GetPlayerByIdAsync(playerId);
            });
    }

    public ICollection<Player> GetAllPlayers()
    {
        return _decorated.GetAllPlayers();
    }
}