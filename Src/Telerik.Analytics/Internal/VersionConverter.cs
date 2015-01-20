using System;
using Newtonsoft.Json;

namespace Telerik.Analytics.Internal
{
    internal class VersionConverter : JsonConverter
    {
        public override bool CanConvert(Type type)
        {
            return typeof(Version) == type;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String)
                throw new Exception(String.Format("Unexpected token parsing Version. Expected String, got {0}.", reader.TokenType));
            var value = reader.Value as string;
            return Version.Parse(value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (!(value is Version)) throw new Exception("Expected version object value.");
            var version = (value as Version).ToString();
            writer.WriteValue(version);
        }

    }
}