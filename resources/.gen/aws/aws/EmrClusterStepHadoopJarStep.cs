using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.EmrClusterStepHadoopJarStep")]
    public class EmrClusterStepHadoopJarStep : aws.IEmrClusterStepHadoopJarStep
    {
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Args
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "jar", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Jar
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mainClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MainClass
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
    }
}
