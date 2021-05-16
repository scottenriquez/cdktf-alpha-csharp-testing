using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EcsTaskDefinitionVolume")]
    public class EcsTaskDefinitionVolume : aws.IEcsTaskDefinitionVolume
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>docker_volume_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dockerVolumeConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolumeDockerVolumeConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsTaskDefinitionVolumeDockerVolumeConfiguration[]? DockerVolumeConfiguration
        {
            get;
            set;
        }

        /// <summary>efs_volume_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "efsVolumeConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolumeEfsVolumeConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsTaskDefinitionVolumeEfsVolumeConfiguration[]? EfsVolumeConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HostPath
        {
            get;
            set;
        }
    }
}
