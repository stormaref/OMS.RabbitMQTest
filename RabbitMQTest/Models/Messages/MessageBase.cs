using Newtonsoft.Json;

namespace RabbitMQTest.Models.Messages;

public class MessageBase<TMessageBody> where TMessageBody : class
{
    [JsonProperty("RLCDiffHeader")] public RlcDiffHeader RLCDiffHeader { get; set; }

    [JsonProperty("Message")] public TMessageBody Message { get; set; }
}