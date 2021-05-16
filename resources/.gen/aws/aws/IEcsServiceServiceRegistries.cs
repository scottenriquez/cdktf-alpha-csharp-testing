using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceRegistries), fullyQualifiedName: "aws.EcsServiceServiceRegistries")]
    public interface IEcsServiceServiceRegistries
    {
        [JsiiProperty(name: "registryArn", typeJson: "{\"primitive\":\"string\"}")]
        string RegistryArn
        {
            get;
        }

        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ContainerPort
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceRegistries), fullyQualifiedName: "aws.EcsServiceServiceRegistries")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsServiceServiceRegistries
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "registryArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RegistryArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ContainerPort
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
