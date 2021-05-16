using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodecommitTriggerTrigger")]
    public class CodecommitTriggerTrigger : aws.ICodecommitTriggerTrigger
    {
        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DestinationArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Events
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "branches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Branches
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customData", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CustomData
        {
            get;
            set;
        }
    }
}
