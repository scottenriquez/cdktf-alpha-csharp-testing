using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EcsServiceServiceRegistries")]
    public class EcsServiceServiceRegistries : aws.IEcsServiceServiceRegistries
    {
        [JsiiProperty(name: "registryArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RegistryArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ContainerName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ContainerPort
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}
