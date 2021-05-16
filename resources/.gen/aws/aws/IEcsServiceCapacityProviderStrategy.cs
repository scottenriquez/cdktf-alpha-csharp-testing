using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsServiceCapacityProviderStrategy), fullyQualifiedName: "aws.EcsServiceCapacityProviderStrategy")]
    public interface IEcsServiceCapacityProviderStrategy
    {
        [JsiiProperty(name: "capacityProvider", typeJson: "{\"primitive\":\"string\"}")]
        string CapacityProvider
        {
            get;
        }

        [JsiiProperty(name: "base", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Base
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Weight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceCapacityProviderStrategy), fullyQualifiedName: "aws.EcsServiceCapacityProviderStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsServiceCapacityProviderStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "capacityProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string CapacityProvider
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "base", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Base
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Weight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
