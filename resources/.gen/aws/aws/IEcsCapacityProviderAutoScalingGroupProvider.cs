using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsCapacityProviderAutoScalingGroupProvider), fullyQualifiedName: "aws.EcsCapacityProviderAutoScalingGroupProvider")]
    public interface IEcsCapacityProviderAutoScalingGroupProvider
    {
        [JsiiProperty(name: "autoScalingGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string AutoScalingGroupArn
        {
            get;
        }

        /// <summary>managed_scaling block.</summary>
        [JsiiProperty(name: "managedScaling", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling[]? ManagedScaling
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "managedTerminationProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedTerminationProtection
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsCapacityProviderAutoScalingGroupProvider), fullyQualifiedName: "aws.EcsCapacityProviderAutoScalingGroupProvider")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsCapacityProviderAutoScalingGroupProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "autoScalingGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AutoScalingGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>managed_scaling block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedScaling", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling[]? ManagedScaling
            {
                get => GetInstanceProperty<aws.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "managedTerminationProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedTerminationProtection
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
