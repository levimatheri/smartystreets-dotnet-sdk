﻿using Smarty.Net.Core.Shared;

namespace Smarty.Net.Core.USStreetApi;

public class Batch : Batch<Lookup>
{
    private const int MaxBatchSize = 100;
    public Batch() : base(MaxBatchSize)
    {
    }
}