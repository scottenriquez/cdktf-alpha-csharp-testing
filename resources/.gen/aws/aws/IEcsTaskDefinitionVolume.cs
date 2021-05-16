using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionVolume), fullyQualifiedName: "aws.EcsTaskDefinitionVolume")]
    public interface IEcsTaskDefinitionVolume
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>docker_volume_configuration block.</summary>
        [JsiiProperty(name: "dockerVolumeConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolumeDockerVolumeConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsTaskDefinitionVolumeDockerVolumeConfiguration[]? DockerVolumeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>efs_volume_configuration block.</summary>
        [JsiiProperty(name: "efsVolumeConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolumeEfsVolumeConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsTaskDefinitionVolumeEfsVolumeConfiguration[]? EfsVolumeConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "hostPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionVolume), fullyQualifiedName: "aws.EcsTaskDefinitionVolume")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsTaskDefinitionVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>docker_volume_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dockerVolumeConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolumeDockerVolumeConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsTaskDefinitionVolumeDockerVolumeConfiguration[]? DockerVolumeConfiguration
            {
                get => GetInstanceProperty<aws.IEcsTaskDefinitionVolumeDockerVolumeConfiguration[]?>();
            }

            /// <summary>efs_volume_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "efsVolumeConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolumeEfsVolumeConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsTaskDefinitionVolumeEfsVolumeConfiguration[]? EfsVolumeConfiguration
            {
                get => GetInstanceProperty<aws.IEcsTaskDefinitionVolumeEfsVolumeConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "hostPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
