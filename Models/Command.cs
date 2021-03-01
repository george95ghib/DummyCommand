using System;
using System.Text.Json.Serialization;
using DummyCommand.Data;

namespace DummyCommand.Models
{
    public class Command
    {
        
        public int Id { get; set; }

        public string HowTo { get; set; }

        public string Line { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Platform Platform { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}