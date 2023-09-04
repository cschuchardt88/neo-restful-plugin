// Copyright (C) 2015-2023 neo-restful-plugin.
//
// The RestServerPlugin is free software distributed under the MIT software
// license, see the accompanying file LICENSE in the main directory of
// the project or http://www.opensource.org/licenses/mit-license.php
// for more details.
//
// Redistribution and use in source and binary forms with or without
// modifications are permitted.

namespace Neo.Plugins.Example.Models
{
    internal class ErrorModel
    {
        public int Code { get; init; } = 1000;
        public string Name { get; init; } = "GeneralException";
        public string Message { get; init; } = "An error occurred.";
    }
}
