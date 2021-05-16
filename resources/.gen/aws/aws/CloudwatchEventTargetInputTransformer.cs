using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudwatchEventTargetInputTransformer")]
    public class CloudwatchEventTargetInputTransformer : aws.ICloudwatchEventTargetInputTransformer
    {
        [JsiiProperty(name: "inputTemplate", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InputTemplate
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? InputPaths
        {
            get;
            set;
        }
    }
}
