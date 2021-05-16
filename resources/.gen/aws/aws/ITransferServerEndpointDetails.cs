using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ITransferServerEndpointDetails), fullyQualifiedName: "aws.TransferServerEndpointDetails")]
    public interface ITransferServerEndpointDetails
    {
        [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcEndpointId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferServerEndpointDetails), fullyQualifiedName: "aws.TransferServerEndpointDetails")]
        internal sealed class _Proxy : DeputyBase, aws.ITransferServerEndpointDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcEndpointId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
