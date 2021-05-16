using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionTimeout), fullyQualifiedName: "aws.BatchJobDefinitionTimeout")]
    public interface IBatchJobDefinitionTimeout
    {
        [JsiiProperty(name: "attemptDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AttemptDurationSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionTimeout), fullyQualifiedName: "aws.BatchJobDefinitionTimeout")]
        internal sealed class _Proxy : DeputyBase, aws.IBatchJobDefinitionTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "attemptDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AttemptDurationSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
