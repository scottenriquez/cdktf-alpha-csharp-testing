using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISpotInstanceRequestCreditSpecification), fullyQualifiedName: "aws.SpotInstanceRequestCreditSpecification")]
    public interface ISpotInstanceRequestCreditSpecification
    {
        [JsiiProperty(name: "cpuCredits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CpuCredits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotInstanceRequestCreditSpecification), fullyQualifiedName: "aws.SpotInstanceRequestCreditSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.ISpotInstanceRequestCreditSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "cpuCredits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CpuCredits
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
