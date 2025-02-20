﻿using Refit;
using Smarty.Net.Core.Shared;
using System.Runtime.Serialization;

namespace Smarty.Net.Core.USStreetApi;

public class Lookup : ILookup
{
    [AliasAs("input_id")]
    public string? InputId { get; set; }

    [AliasAs("street")]
    public string? Street { get; set; }

    [AliasAs("street2")]
    public string? Street2 { get; set; }

    [AliasAs("secondary")]
    public string? Secondary { get; set; }

    [AliasAs("city")]
    public string? City { get; set; }

    [AliasAs("state")]
    public string? State { get; set; }

    [AliasAs("zipcode")]
    public string? ZipCode { get; set; }

    [AliasAs("lastline")]
    public string? Lastline { get; set; }

    [AliasAs("addressee")]
    public string? Addressee { get; set; }

    [AliasAs("urbanization")]
    public string? Urbanization { get; set; }

    [AliasAs("candidates")]
    public int MaxCandidates { get; set; } = 1;

    [AliasAs("match")]
    public MatchStrategy? Match { get; set; } = MatchStrategy.Strict;

    public enum MatchStrategy
    {
        [EnumMember(Value = "strict")]
        Strict = 1,

        [EnumMember(Value = "enhanced")]
        Enhanced = 2,

        [EnumMember(Value = "invalid")]
        Invalid = 3
    }
}
