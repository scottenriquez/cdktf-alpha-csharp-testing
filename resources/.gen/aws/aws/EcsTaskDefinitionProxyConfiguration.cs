using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EcsTaskDefinitionProxyConfiguration")]
    public class EcsTaskDefinitionProxyConfiguration : aws.IEcsTaskDefinitionProxyConfiguration
    {
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ContainerName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Properties
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
