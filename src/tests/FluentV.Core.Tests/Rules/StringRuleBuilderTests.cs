﻿using FluentV.Core.Patterns;
using FluentV.Core.Tests.Samples.Contracts;
using FluentV.Core.Tests.Samples.Entities;

namespace FluentV.Core.Tests.Rules;
public class StringRuleBuilderTests
{
    public SampleContract _contract = new SampleContract();

    [Fact]
    public void Not_White_Space()
    {
        Assert.Contains(DefaultMessage.WhiteSpace, _contract.Rules[nameof(SampleEntity.WhiteSpaceString)].Rules.First().Message);
        Assert.Equal("Values that are not white spaces", _contract.Rules[nameof(SampleEntity.WhiteSpaceString)].Rules.First().AcceptedValues.First());
    }

    [Fact]
    public void Not_Empty_String()
    {
        Assert.Contains(DefaultMessage.NotEmpty, _contract.Rules[nameof(SampleEntity.EmptyString)].Rules.First().Message);
        Assert.Equal("Values that are not ''", _contract.Rules[nameof(SampleEntity.EmptyString)].Rules.First().AcceptedValues.First());
    }
}
