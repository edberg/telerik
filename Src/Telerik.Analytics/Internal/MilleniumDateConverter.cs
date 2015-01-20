using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Telerik.Analytics.Internal
{
    internal class MilleniumDateConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            long days;
            if (value is DateTime)
            {
                var epoc = new DateTime(2000, 1, 1);
                var delta = ((DateTime)value) - epoc;
                if (delta.TotalSeconds < 0)
                    throw new ArgumentOutOfRangeException("Millenium starts January 1st, 2000");
                days = (long)delta.TotalDays;
            }
            else
            {
                throw new Exception("Expected date object value.");
            }
            writer.WriteValue(days);
        }

        public override object ReadJson(JsonReader reader, Type type, object value, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Integer)
                throw new Exception(String.Format("Unexpected token parsing date. Expected Integer, got {0}.", reader.TokenType));

            var days = (long)reader.Value;
            var date = new DateTime(2000, 1, 1);
            date = date.AddDays(days);
            return date;
        }
    }
}