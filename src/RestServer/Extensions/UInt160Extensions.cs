// Copyright (C) 2015-2023 The Neo Project.
//
// The Neo.Plugins.RestServer is free software distributed under the MIT software license,
// see the accompanying file LICENSE in the main directory of the
// project or http://www.opensource.org/licenses/mit-license.php
// for more details.
//
// Redistribution and use in source and binary forms with or without
// modifications are permitted.

using Neo.Plugins.RestServer.Helpers;
using Neo.SmartContract.Native;

namespace Neo.Plugins.RestServer.Extensions
{
    internal static class UInt160Extensions
    {
        public static bool IsValidNep17(this UInt160 scriptHash)
        {
            var contractState = NativeContract.ContractManagement.GetContract(RestServerPlugin.NeoSystem.StoreView, scriptHash);
            return ContractHelper.IsNep17Supported(contractState);
        }

        public static bool IsValidContract(this UInt160 scriptHash) =>
            NativeContract.ContractManagement.GetContract(RestServerPlugin.NeoSystem.StoreView, scriptHash) != null;
    }
}
