using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(INetworkInterfaceAttachment), fullyQualifiedName: "aws.NetworkInterfaceAttachment")]
    public interface INetworkInterfaceAttachment
    {
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}")]
        double DeviceIndex
        {
            get;
        }

        [JsiiProperty(name: "instance", typeJson: "{\"primitive\":\"string\"}")]
        string Instance
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkInterfaceAttachment), fullyQualifiedName: "aws.NetworkInterfaceAttachment")]
        internal sealed class _Proxy : DeputyBase, aws.INetworkInterfaceAttachment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}")]
            public double DeviceIndex
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "instance", typeJson: "{\"primitive\":\"string\"}")]
            public string Instance
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
