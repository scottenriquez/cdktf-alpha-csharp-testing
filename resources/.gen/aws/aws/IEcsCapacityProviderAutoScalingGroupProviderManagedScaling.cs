using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsCapacityProviderAutoScalingGroupProviderManagedScaling), fullyQualifiedName: "aws.EcsCapacityProviderAutoScalingGroupProviderManagedScaling")]
    public interface IEcsCapacityProviderAutoScalingGroupProviderManagedScaling
    {
        [JsiiProperty(name: "maximumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumScalingStepSize
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "minimumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumScalingStepSize
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsCapacityProviderAutoScalingGroupProviderManagedScaling), fullyQualifiedName: "aws.EcsCapacityProviderAutoScalingGroupProviderManagedScaling")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "maximumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumScalingStepSize
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "minimumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumScalingStepSize
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetCapacity
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
