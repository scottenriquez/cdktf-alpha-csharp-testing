using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEc2FleetLaunchTemplateConfig), fullyQualifiedName: "aws.Ec2FleetLaunchTemplateConfig")]
    public interface IEc2FleetLaunchTemplateConfig
    {
        /// <summary>launch_template_specification block.</summary>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification\"},\"kind\":\"array\"}}")]
        aws.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification[] LaunchTemplateSpecification
        {
            get;
        }

        /// <summary>override block.</summary>
        [JsiiProperty(name: "override", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetLaunchTemplateConfigOverride\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEc2FleetLaunchTemplateConfigOverride[]? Override
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetLaunchTemplateConfig), fullyQualifiedName: "aws.Ec2FleetLaunchTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEc2FleetLaunchTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template_specification block.</summary>
            [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification\"},\"kind\":\"array\"}}")]
            public aws.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification[] LaunchTemplateSpecification
            {
                get => GetInstanceProperty<aws.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification[]>()!;
            }

            /// <summary>override block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "override", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetLaunchTemplateConfigOverride\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEc2FleetLaunchTemplateConfigOverride[]? Override
            {
                get => GetInstanceProperty<aws.IEc2FleetLaunchTemplateConfigOverride[]?>();
            }
        }
    }
}
