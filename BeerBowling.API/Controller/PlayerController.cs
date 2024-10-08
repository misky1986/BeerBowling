using BeerBowling.Application.Players.Queries;
using BeerBowling.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BeerBowling.API.Controller;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
    private readonly ILogger<PlayerController> _logger;
    private readonly IMediator _mediator;
    
    public PlayerController(ILogger<PlayerController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }
    
    [HttpGet("GetPlayerById")]
    public async Task<ActionResult<Player>> GetPlayerById(int playerId)
    {
        Player? player = await _mediator.Send(new GetPlayerByIdQuery(playerId));
        _logger.LogInformation($"Get player with id: {playerId}");
        
        return Ok(player);
    }
    
    [HttpGet("GetPlayers")]
    public async Task<ActionResult<List<Player>>> GetPlayers()
    {
        _logger.LogInformation("GetPlayers");
        var players = await _mediator.Send(new GetPlayersQuery());
        return Ok(players);
    }
}