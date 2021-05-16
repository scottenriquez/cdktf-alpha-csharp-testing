using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification), fullyQualifiedName: "aws.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification")]
    public interface IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification
    {
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        [JsiiProperty(name: "launchTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchTemplateId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "launchTemplateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchTemplateName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification), fullyQualifiedName: "aws.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "launchTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchTemplateId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "launchTemplateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchTemplateName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
