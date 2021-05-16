using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig")]
    public class EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig : aws.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "accessPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AccessPointId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iam", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Iam
        {
            get;
            set;
        }
    }
}
