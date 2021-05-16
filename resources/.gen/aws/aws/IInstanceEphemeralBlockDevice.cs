using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IInstanceEphemeralBlockDevice), fullyQualifiedName: "aws.InstanceEphemeralBlockDevice")]
    public interface IInstanceEphemeralBlockDevice
    {
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceName
        {
            get;
        }

        [JsiiProperty(name: "noDevice", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? NoDevice
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceEphemeralBlockDevice), fullyQualifiedName: "aws.InstanceEphemeralBlockDevice")]
        internal sealed class _Proxy : DeputyBase, aws.IInstanceEphemeralBlockDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "noDevice", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? NoDevice
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
