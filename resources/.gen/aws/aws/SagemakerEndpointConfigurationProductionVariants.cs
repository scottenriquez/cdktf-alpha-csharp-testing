using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SagemakerEndpointConfigurationProductionVariants")]
    public class SagemakerEndpointConfigurationProductionVariants : aws.ISagemakerEndpointConfigurationProductionVariants
    {
        [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double InitialInstanceCount
        {
            get;
            set;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceType
        {
            get;
            set;
        }

        [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ModelName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AcceleratorType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialVariantWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? InitialVariantWeight
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "variantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VariantName
        {
            get;
            set;
        }
    }
}
