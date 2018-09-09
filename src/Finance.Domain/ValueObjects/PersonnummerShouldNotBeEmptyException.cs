﻿namespace Finance.Domain.ValueObjects
{
    public sealed class PersonnummerShouldNotBeEmptyException : DomainException
    {
        internal PersonnummerShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}