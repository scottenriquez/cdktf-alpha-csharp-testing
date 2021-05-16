using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILbSubnetMapping), fullyQualifiedName: "aws.LbSubnetMapping")]
    public interface ILbSubnetMapping
    {
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        [JsiiProperty(name: "allocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllocationId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbSubnetMapping), fullyQualifiedName: "aws.LbSubnetMapping")]
        internal sealed class _Proxy : DeputyBase, aws.ILbSubnetMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "allocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllocationId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
