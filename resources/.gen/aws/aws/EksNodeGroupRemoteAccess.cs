using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.EksNodeGroupRemoteAccess")]
    public class EksNodeGroupRemoteAccess : aws.IEksNodeGroupRemoteAccess
    {
        [JsiiOptional]
        [JsiiProperty(name: "ec2SshKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Ec2SshKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SourceSecurityGroupIds
        {
            get;
            set;
        }
    }
}
