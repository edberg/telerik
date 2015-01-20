using System;
using Newtonsoft.Json;

namespace Telerik.Analytics.Internal
{
    internal class MillisecondsTimeSpanConverter : JsonConverter
    {
        public override bool CanConvert(Type type)
        {
            return typeof(TimeSpan) == type;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String)
                throw new Exception(String.Format("Unexpected token parsing TimeSpan. Expected String, got {0}.", reader.TokenType));
            var milliseconds = long.Parse(reader.Value as string);
            return TimeSpan.FromMilliseconds(milliseconds);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (!(value is TimeSpan)) throw new Exception("Expected date object value.");
            long milliseconds = Convert.ToInt64((value as TimeSpan?).Value.TotalMilliseconds);
            writer.WriteValue(milliseconds);
        }
    }
}