using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GameliftAliasRoutingStrategy")]
    public class GameliftAliasRoutingStrategy : aws.IGameliftAliasRoutingStrategy
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FleetId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Message
        {
            get;
            set;
        }
    }
}
