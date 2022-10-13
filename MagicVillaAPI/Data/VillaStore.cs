﻿using MagicVillaAPI.Models.Dto;

namespace MagicVillaAPI.Data;

public static class VillaStore
{
    public static List<VillaDTO> Villas = new List<VillaDTO>()
    {
        new VillaDTO { Id = 1, Name = "Villa1" },
        new VillaDTO { Id = 2, Name = "Villa2" }
    };
}