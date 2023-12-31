// Copyright (C) 2015-2023 The Neo Project.
//
// The Neo.Plugins.RestServer is free software distributed under the MIT software license,
// see the accompanying file LICENSE in the main directory of the
// project or http://www.opensource.org/licenses/mit-license.php
// for more details.
//
// Redistribution and use in source and binary forms with or without
// modifications are permitted.

using Neo.Plugins.RestServer.Exceptions;

namespace Neo.Plugins.RestServer.Models.Error
{
    internal class ParameterFormatExceptionModel : ErrorModel
    {
        public ParameterFormatExceptionModel()
        {
            Code = RestErrorCodes.ParameterFormatException;
            Name = nameof(RestErrorCodes.ParameterFormatException);
        }

        public ParameterFormatExceptionModel(string message) : this()
        {
            Message = message;
        }
    }
}
