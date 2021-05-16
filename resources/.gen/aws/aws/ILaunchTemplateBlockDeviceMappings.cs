using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateBlockDeviceMappings), fullyQualifiedName: "aws.LaunchTemplateBlockDeviceMappings")]
    public interface ILaunchTemplateBlockDeviceMappings
    {
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeviceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs block.</summary>
        [JsiiProperty(name: "ebs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateBlockDeviceMappingsEbs\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateBlockDeviceMappingsEbs[]? Ebs
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "noDevice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NoDevice
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

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateBlockDeviceMappings), fullyQualifiedName: "aws.LaunchTemplateBlockDeviceMappings")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateBlockDeviceMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ebs block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateBlockDeviceMappingsEbs\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateBlockDeviceMappingsEbs[]? Ebs
            {
                get => GetInstanceProperty<aws.ILaunchTemplateBlockDeviceMappingsEbs[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "noDevice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NoDevice
            {
                get => GetInstanceProperty<string?>();
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
