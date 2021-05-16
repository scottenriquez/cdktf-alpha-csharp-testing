using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointConfigurationProductionVariants), fullyQualifiedName: "aws.SagemakerEndpointConfigurationProductionVariants")]
    public interface ISagemakerEndpointConfigurationProductionVariants
    {
        [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double InitialInstanceCount
        {
            get;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}")]
        string ModelName
        {
            get;
        }

        [JsiiProperty(name: "acceleratorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AcceleratorType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "initialVariantWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InitialVariantWeight
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "variantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VariantName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointConfigurationProductionVariants), fullyQualifiedName: "aws.SagemakerEndpointConfigurationProductionVariants")]
        internal sealed class _Proxy : DeputyBase, aws.ISagemakerEndpointConfigurationProductionVariants
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double InitialInstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "acceleratorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AcceleratorType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "initialVariantWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InitialVariantWeight
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "variantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VariantName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
