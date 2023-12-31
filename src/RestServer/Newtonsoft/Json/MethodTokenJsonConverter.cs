// Copyright (C) 2015-2023 The Neo Project.
//
// The Neo.Plugins.RestServer is free software distributed under the MIT software license,
// see the accompanying file LICENSE in the main directory of the
// project or http://www.opensource.org/licenses/mit-license.php
// for more details.
//
// Redistribution and use in source and binary forms with or without
// modifications are permitted.

using Neo.SmartContract;
using Newtonsoft.Json;

namespace Neo.Plugins.RestServer.Newtonsoft.Json;

public class MethodTokenJsonConverter : JsonConverter<MethodToken>
{
    public override bool CanRead => false;

    public override bool CanWrite => true;

    public override MethodToken ReadJson(JsonReader reader, Type objectType, MethodToken existingValue, bool hasExistingValue, global::Newtonsoft.Json.JsonSerializer serializer) => throw new NotImplementedException();
    public override void WriteJson(JsonWriter writer, MethodToken value, global::Newtonsoft.Json.JsonSerializer serializer)
    {
        var j = RestServerUtility.MethodTokenToJToken(value, serializer);
        j.WriteTo(writer);
    }
}
