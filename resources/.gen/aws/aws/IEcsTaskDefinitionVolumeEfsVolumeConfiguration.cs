using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionVolumeEfsVolumeConfiguration), fullyQualifiedName: "aws.EcsTaskDefinitionVolumeEfsVolumeConfiguration")]
    public interface IEcsTaskDefinitionVolumeEfsVolumeConfiguration
    {
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemId
        {
            get;
        }

        /// <summary>authorization_config block.</summary>
        [JsiiProperty(name: "authorizationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig[]? AuthorizationConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RootDirectory
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "transitEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransitEncryption
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "transitEncryptionPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TransitEncryptionPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionVolumeEfsVolumeConfiguration), fullyQualifiedName: "aws.EcsTaskDefinitionVolumeEfsVolumeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsTaskDefinitionVolumeEfsVolumeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authorization_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig[]? AuthorizationConfig
            {
                get => GetInstanceProperty<aws.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RootDirectory
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "transitEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransitEncryption
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "transitEncryptionPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TransitEncryptionPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
