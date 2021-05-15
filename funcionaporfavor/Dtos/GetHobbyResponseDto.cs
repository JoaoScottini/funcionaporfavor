using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace funcionaporfavor.Dtos
{
    public record GetHobbyResponseDto
    {

        public Guid Id { get; init; }
        public string Name { get; init; }
        public DateTime CreatedAt { get; init; }

    }
}
