using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestLaunchTemplateConfig), fullyQualifiedName: "aws.SpotFleetRequestLaunchTemplateConfig")]
    public interface ISpotFleetRequestLaunchTemplateConfig
    {
        /// <summary>launch_template_specification block.</summary>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification\"},\"kind\":\"array\"}}")]
        aws.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification[] LaunchTemplateSpecification
        {
            get;
        }

        /// <summary>overrides block.</summary>
        [JsiiProperty(name: "overrides", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchTemplateConfigOverrides\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISpotFleetRequestLaunchTemplateConfigOverrides[]? Overrides
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestLaunchTemplateConfig), fullyQualifiedName: "aws.SpotFleetRequestLaunchTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ISpotFleetRequestLaunchTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template_specification block.</summary>
            [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification\"},\"kind\":\"array\"}}")]
            public aws.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification[] LaunchTemplateSpecification
            {
                get => GetInstanceProperty<aws.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification[]>()!;
            }

            /// <summary>overrides block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "overrides", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchTemplateConfigOverrides\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISpotFleetRequestLaunchTemplateConfigOverrides[]? Overrides
            {
                get => GetInstanceProperty<aws.ISpotFleetRequestLaunchTemplateConfigOverrides[]?>();
            }
        }
    }
}
