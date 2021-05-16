using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EcsServiceCapacityProviderStrategy")]
    public class EcsServiceCapacityProviderStrategy : aws.IEcsServiceCapacityProviderStrategy
    {
        [JsiiProperty(name: "capacityProvider", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CapacityProvider
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "base", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Base
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}
