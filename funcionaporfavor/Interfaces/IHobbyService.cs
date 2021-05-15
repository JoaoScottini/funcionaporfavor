using funcionaporfavor.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace funcionaporfavor.Interfaces
{
    public interface IHobbyService
    {

        Task<GetHobbyListResponseDto> GetByPageAsync(int limit, int page, CancellationToken cancellationToken);

    }
}
