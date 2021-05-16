using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3AccessPointVpcConfiguration), fullyQualifiedName: "aws.S3AccessPointVpcConfiguration")]
    public interface IS3AccessPointVpcConfiguration
    {
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3AccessPointVpcConfiguration), fullyQualifiedName: "aws.S3AccessPointVpcConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IS3AccessPointVpcConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
