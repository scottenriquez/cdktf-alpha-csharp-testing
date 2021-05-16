using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EcsServiceLoadBalancer")]
    public class EcsServiceLoadBalancer : aws.IEcsServiceLoadBalancer
    {
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ContainerName
        {
            get;
            set;
        }

        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ContainerPort
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "elbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ElbName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TargetGroupArn
        {
            get;
            set;
        }
    }
}
