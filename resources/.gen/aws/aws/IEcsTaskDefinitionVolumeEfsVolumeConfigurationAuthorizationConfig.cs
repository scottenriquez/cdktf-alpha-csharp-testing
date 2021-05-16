using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig), fullyQualifiedName: "aws.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig")]
    public interface IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig
    {
        [JsiiProperty(name: "accessPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessPointId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "iam", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Iam
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig), fullyQualifiedName: "aws.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "accessPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessPointId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "iam", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Iam
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
