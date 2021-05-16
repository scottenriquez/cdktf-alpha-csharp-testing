using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDefaultNetworkAclIngress), fullyQualifiedName: "aws.DefaultNetworkAclIngress")]
    public interface IDefaultNetworkAclIngress
    {
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
        double FromPort
        {
            get;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        [JsiiProperty(name: "ruleNo", typeJson: "{\"primitive\":\"number\"}")]
        double RuleNo
        {
            get;
        }

        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
        double ToPort
        {
            get;
        }

        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CidrBlock
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "icmpCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IcmpCode
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "icmpType", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IcmpType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6CidrBlock
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDefaultNetworkAclIngress), fullyQualifiedName: "aws.DefaultNetworkAclIngress")]
        internal sealed class _Proxy : DeputyBase, aws.IDefaultNetworkAclIngress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
            public double FromPort
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "ruleNo", typeJson: "{\"primitive\":\"number\"}")]
            public double RuleNo
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ToPort
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CidrBlock
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "icmpCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IcmpCode
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "icmpType", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IcmpType
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6CidrBlock
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
