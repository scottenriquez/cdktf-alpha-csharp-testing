using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupRemoteAccess), fullyQualifiedName: "aws.EksNodeGroupRemoteAccess")]
    public interface IEksNodeGroupRemoteAccess
    {
        [JsiiProperty(name: "ec2SshKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ec2SshKey
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sourceSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourceSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupRemoteAccess), fullyQualifiedName: "aws.EksNodeGroupRemoteAccess")]
        internal sealed class _Proxy : DeputyBase, aws.IEksNodeGroupRemoteAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "ec2SshKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ec2SshKey
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sourceSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourceSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
