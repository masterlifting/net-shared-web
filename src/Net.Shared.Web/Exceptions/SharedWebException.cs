﻿using Shared.Exceptions.Abstractions;
using Shared.Exceptions.Models;

namespace Net.Shared.Web.Exceptions;

public sealed class SharedWebException : SharedException
{
    public SharedWebException(string initiator, string action, ExceptionDescription description) : base(initiator, action, description) { }
}