using BeerBowling.Domain.IRepository;
using BeerBowling.Domain.Models;
using MediatR;

namespace BeerBowling.Application.Players.Queries;

public record GetPlayersQuery : IRequest<ICollection<Player?>>{}

public class GetPlayersHandler : IRequestHandler<GetPlayersQuery, ICollection<Player?>>
{
    private readonly IPlayerRepository _playerRepository;

    public GetPlayersHandler(IPlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }

    public async Task<ICollection<Player?>> Handle(GetPlayersQuery request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(_playerRepository.GetAllPlayers());
    }
}