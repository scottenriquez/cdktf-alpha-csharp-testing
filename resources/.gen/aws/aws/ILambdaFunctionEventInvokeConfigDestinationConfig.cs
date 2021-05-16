using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfig), fullyQualifiedName: "aws.LambdaFunctionEventInvokeConfigDestinationConfig")]
    public interface ILambdaFunctionEventInvokeConfigDestinationConfig
    {
        /// <summary>on_failure block.</summary>
        [JsiiProperty(name: "onFailure", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure[]? OnFailure
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_success block.</summary>
        [JsiiProperty(name: "onSuccess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess[]? OnSuccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfig), fullyQualifiedName: "aws.LambdaFunctionEventInvokeConfigDestinationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ILambdaFunctionEventInvokeConfigDestinationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_failure block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onFailure", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure[]? OnFailure
            {
                get => GetInstanceProperty<aws.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure[]?>();
            }

            /// <summary>on_success block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onSuccess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess[]? OnSuccess
            {
                get => GetInstanceProperty<aws.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess[]?>();
            }
        }
    }
}
