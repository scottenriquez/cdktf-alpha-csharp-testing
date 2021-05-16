using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsServiceLoadBalancer), fullyQualifiedName: "aws.EcsServiceLoadBalancer")]
    public interface IEcsServiceLoadBalancer
    {
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerName
        {
            get;
        }

        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}")]
        double ContainerPort
        {
            get;
        }

        [JsiiProperty(name: "elbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ElbName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetGroupArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceLoadBalancer), fullyQualifiedName: "aws.EcsServiceLoadBalancer")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsServiceLoadBalancer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ContainerPort
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "elbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ElbName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetGroupArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
