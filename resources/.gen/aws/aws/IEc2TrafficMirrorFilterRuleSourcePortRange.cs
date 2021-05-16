using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEc2TrafficMirrorFilterRuleSourcePortRange), fullyQualifiedName: "aws.Ec2TrafficMirrorFilterRuleSourcePortRange")]
    public interface IEc2TrafficMirrorFilterRuleSourcePortRange
    {
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FromPort
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ToPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2TrafficMirrorFilterRuleSourcePortRange), fullyQualifiedName: "aws.Ec2TrafficMirrorFilterRuleSourcePortRange")]
        internal sealed class _Proxy : DeputyBase, aws.IEc2TrafficMirrorFilterRuleSourcePortRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FromPort
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ToPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
