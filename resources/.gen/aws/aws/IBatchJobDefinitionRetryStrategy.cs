using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionRetryStrategy), fullyQualifiedName: "aws.BatchJobDefinitionRetryStrategy")]
    public interface IBatchJobDefinitionRetryStrategy
    {
        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Attempts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionRetryStrategy), fullyQualifiedName: "aws.BatchJobDefinitionRetryStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.IBatchJobDefinitionRetryStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Attempts
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
