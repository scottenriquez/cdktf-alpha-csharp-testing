using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension), fullyQualifiedName: "aws.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension")]
    public interface IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension), fullyQualifiedName: "aws.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension")]
        internal sealed class _Proxy : DeputyBase, aws.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
