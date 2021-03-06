using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace funcionaporfavor.Dtos
{
    public record GetHobbyListResponseDto
    {

        public int CurrentPage { get; init; }

        public int TotalItems { get; init; }

        public int TotalPages { get; init; }

        public List<GetHobbyResponseDto> Items { get; init; }

    }
}
