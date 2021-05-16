using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueJobExecutionProperty), fullyQualifiedName: "aws.GlueJobExecutionProperty")]
    public interface IGlueJobExecutionProperty
    {
        [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentRuns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueJobExecutionProperty), fullyQualifiedName: "aws.GlueJobExecutionProperty")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueJobExecutionProperty
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentRuns
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
