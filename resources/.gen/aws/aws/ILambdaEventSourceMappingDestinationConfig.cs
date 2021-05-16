using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingDestinationConfig), fullyQualifiedName: "aws.LambdaEventSourceMappingDestinationConfig")]
    public interface ILambdaEventSourceMappingDestinationConfig
    {
        /// <summary>on_failure block.</summary>
        [JsiiProperty(name: "onFailure", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaEventSourceMappingDestinationConfigOnFailure\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILambdaEventSourceMappingDestinationConfigOnFailure[]? OnFailure
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingDestinationConfig), fullyQualifiedName: "aws.LambdaEventSourceMappingDestinationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ILambdaEventSourceMappingDestinationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_failure block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onFailure", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaEventSourceMappingDestinationConfigOnFailure\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILambdaEventSourceMappingDestinationConfigOnFailure[]? OnFailure
            {
                get => GetInstanceProperty<aws.ILambdaEventSourceMappingDestinationConfigOnFailure[]?>();
            }
        }
    }
}
