using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionCacheBehaviorLambdaFunctionAssociation), fullyQualifiedName: "aws.CloudfrontDistributionCacheBehaviorLambdaFunctionAssociation")]
    public interface ICloudfrontDistributionCacheBehaviorLambdaFunctionAssociation
    {
        [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
        string EventType
        {
            get;
        }

        [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        string LambdaArn
        {
            get;
        }

        [JsiiProperty(name: "includeBody", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeBody
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionCacheBehaviorLambdaFunctionAssociation), fullyQualifiedName: "aws.CloudfrontDistributionCacheBehaviorLambdaFunctionAssociation")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionCacheBehaviorLambdaFunctionAssociation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
            public string EventType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LambdaArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeBody", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeBody
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
