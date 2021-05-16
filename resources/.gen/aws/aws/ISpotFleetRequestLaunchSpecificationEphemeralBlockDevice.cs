using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice), fullyQualifiedName: "aws.SpotFleetRequestLaunchSpecificationEphemeralBlockDevice")]
    public interface ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice
    {
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceName
        {
            get;
        }

        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice), fullyQualifiedName: "aws.SpotFleetRequestLaunchSpecificationEphemeralBlockDevice")]
        internal sealed class _Proxy : DeputyBase, aws.ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
