using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEc2FleetTargetCapacitySpecification), fullyQualifiedName: "aws.Ec2FleetTargetCapacitySpecification")]
    public interface IEc2FleetTargetCapacitySpecification
    {
        [JsiiProperty(name: "defaultTargetCapacityType", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultTargetCapacityType
        {
            get;
        }

        [JsiiProperty(name: "totalTargetCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double TotalTargetCapacity
        {
            get;
        }

        [JsiiProperty(name: "onDemandTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OnDemandTargetCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "spotTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SpotTargetCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetTargetCapacitySpecification), fullyQualifiedName: "aws.Ec2FleetTargetCapacitySpecification")]
        internal sealed class _Proxy : DeputyBase, aws.IEc2FleetTargetCapacitySpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "defaultTargetCapacityType", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultTargetCapacityType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "totalTargetCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double TotalTargetCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "onDemandTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OnDemandTargetCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "spotTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SpotTargetCapacity
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
