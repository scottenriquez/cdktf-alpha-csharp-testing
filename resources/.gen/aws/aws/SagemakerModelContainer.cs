using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SagemakerModelContainer")]
    public class SagemakerModelContainer : aws.ISagemakerModelContainer
    {
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Image
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ContainerHostname
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Environment
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelDataUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ModelDataUrl
        {
            get;
            set;
        }
    }
}
