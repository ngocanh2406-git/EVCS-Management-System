using EVCS.Application.DTOs;
using EVCS.Domain.Entities;

namespace EVCS.Application.Abstractions.Persistence;

public interface IChargingSessionRepository
{
    Task<List<ChargingSession>> GetListAsync(UsageHistoryFilter filter, CancellationToken cancellationToken);
    Task<bool> HasOngoingSessionByStationAsync(int stationId, CancellationToken cancellationToken);
    Task<bool> HasOngoingSessionByPoleAsync(int poleId, CancellationToken cancellationToken);
    Task DeleteByPoleIdAsync(int poleId, CancellationToken cancellationToken);
}
