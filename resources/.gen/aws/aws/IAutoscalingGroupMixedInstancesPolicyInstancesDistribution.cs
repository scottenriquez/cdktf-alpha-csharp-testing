using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyInstancesDistribution), fullyQualifiedName: "aws.AutoscalingGroupMixedInstancesPolicyInstancesDistribution")]
    public interface IAutoscalingGroupMixedInstancesPolicyInstancesDistribution
    {
        [JsiiProperty(name: "onDemandAllocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnDemandAllocationStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "onDemandBaseCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OnDemandBaseCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "onDemandPercentageAboveBaseCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OnDemandPercentageAboveBaseCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "spotAllocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpotAllocationStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "spotInstancePools", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SpotInstancePools
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "spotMaxPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpotMaxPrice
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyInstancesDistribution), fullyQualifiedName: "aws.AutoscalingGroupMixedInstancesPolicyInstancesDistribution")]
        internal sealed class _Proxy : DeputyBase, aws.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "onDemandAllocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnDemandAllocationStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "onDemandBaseCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OnDemandBaseCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "onDemandPercentageAboveBaseCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OnDemandPercentageAboveBaseCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "spotAllocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotAllocationStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "spotInstancePools", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SpotInstancePools
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "spotMaxPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotMaxPrice
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
