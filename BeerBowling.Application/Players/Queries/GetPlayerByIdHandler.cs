using BeerBowling.Domain.IRepository;
using BeerBowling.Domain.Models;
using MediatR;

namespace BeerBowling.Application.Players.Queries;

public record GetPlayerByIdQuery(int Id) : IRequest<Player?>{}

public class GetPlayerByIdHandler : IRequestHandler<GetPlayerByIdQuery, Player?>
{
    private readonly IPlayerRepository _playerRepository;

    public GetPlayerByIdHandler(IPlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }

    public async Task<Player?> Handle(GetPlayerByIdQuery request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(_playerRepository.GetPlayerByIdAsync(request.Id));
    }
}