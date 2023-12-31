// Copyright (C) 2015-2023 The Neo Project.
//
// The Neo.Plugins.RestServer is free software distributed under the MIT software license,
// see the accompanying file LICENSE in the main directory of the
// project or http://www.opensource.org/licenses/mit-license.php
// for more details.
//
// Redistribution and use in source and binary forms with or without
// modifications are permitted.

using Neo.Network.P2P.Payloads;
using Newtonsoft.Json;

namespace Neo.Plugins.RestServer.Newtonsoft.Json
{
    public class BlockHeaderJsonConverter : JsonConverter<Header>
    {
        public override bool CanRead => false;
        public override bool CanWrite => true;

        public override Header ReadJson(JsonReader reader, Type objectType, Header existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, Header value, JsonSerializer serializer)
        {
            var j = RestServerUtility.BlockHeaderToJToken(value, serializer);
            j.WriteTo(writer);
        }
    }
}
