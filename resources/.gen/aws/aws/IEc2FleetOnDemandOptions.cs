using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEc2FleetOnDemandOptions), fullyQualifiedName: "aws.Ec2FleetOnDemandOptions")]
    public interface IEc2FleetOnDemandOptions
    {
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllocationStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetOnDemandOptions), fullyQualifiedName: "aws.Ec2FleetOnDemandOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IEc2FleetOnDemandOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllocationStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
