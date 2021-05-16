using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionInferenceAccelerator), fullyQualifiedName: "aws.EcsTaskDefinitionInferenceAccelerator")]
    public interface IEcsTaskDefinitionInferenceAccelerator
    {
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceName
        {
            get;
        }

        [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionInferenceAccelerator), fullyQualifiedName: "aws.EcsTaskDefinitionInferenceAccelerator")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsTaskDefinitionInferenceAccelerator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
