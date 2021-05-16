using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EcsTaskDefinitionVolumeEfsVolumeConfiguration")]
    public class EcsTaskDefinitionVolumeEfsVolumeConfiguration : aws.IEcsTaskDefinitionVolumeEfsVolumeConfiguration
    {
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string FileSystemId
        {
            get;
            set;
        }

        /// <summary>authorization_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig[]? AuthorizationConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RootDirectory
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TransitEncryption
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitEncryptionPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TransitEncryptionPort
        {
            get;
            set;
        }
    }
}
