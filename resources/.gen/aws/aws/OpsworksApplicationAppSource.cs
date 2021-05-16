using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.OpsworksApplicationAppSource")]
    public class OpsworksApplicationAppSource : aws.IOpsworksApplicationAppSource
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Password
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Revision
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SshKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Url
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
