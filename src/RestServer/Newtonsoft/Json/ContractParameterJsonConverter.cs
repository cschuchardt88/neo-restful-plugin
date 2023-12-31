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
using Newtonsoft.Json.Linq;

namespace Neo.Plugins.RestServer.Newtonsoft.Json
{
    public class ContractParameterJsonConverter : JsonConverter<ContractParameter>
    {
        public override bool CanRead => true;
        public override bool CanWrite => false;

        public override ContractParameter ReadJson(JsonReader reader, Type objectType, ContractParameter existingValue, bool hasExistingValue, global::Newtonsoft.Json.JsonSerializer serializer)
        {
            var token = JToken.ReadFrom(reader);
            return RestServerUtility.ContractParameterFromJToken(token);
        }

        public override void WriteJson(JsonWriter writer, ContractParameter value, global::Newtonsoft.Json.JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
