using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.EcsTaskDefinitionVolumeDockerVolumeConfiguration")]
    public class EcsTaskDefinitionVolumeDockerVolumeConfiguration : aws.IEcsTaskDefinitionVolumeDockerVolumeConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "autoprovision", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Autoprovision
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Driver
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "driverOpts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? DriverOpts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Scope
        {
            get;
            set;
        }
    }
}
