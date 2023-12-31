// Copyright (C) 2015-2023 The Neo Project.
//
// The Neo.Plugins.RestServer is free software distributed under the MIT software license,
// see the accompanying file LICENSE in the main directory of the
// project or http://www.opensource.org/licenses/mit-license.php
// for more details.
//
// Redistribution and use in source and binary forms with or without
// modifications are permitted.

namespace Neo.Plugins.RestServer.Models.Node
{
    internal class PluginModel
    {
        /// <summary>
        /// Name
        /// </summary>
        /// <example>RestServer</example>
        public string Name { get; set; }
        /// <summary>
        /// Version
        /// </summary>
        /// <example>3.5.0</example>
        public string Version { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        /// <example>Enables REST Web Sevices for the node</example>
        public string Description { get; set; }
    }
}
