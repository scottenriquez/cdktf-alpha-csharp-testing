using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGameliftGameSessionQueuePlayerLatencyPolicy), fullyQualifiedName: "aws.GameliftGameSessionQueuePlayerLatencyPolicy")]
    public interface IGameliftGameSessionQueuePlayerLatencyPolicy
    {
        [JsiiProperty(name: "maximumIndividualPlayerLatencyMilliseconds", typeJson: "{\"primitive\":\"number\"}")]
        double MaximumIndividualPlayerLatencyMilliseconds
        {
            get;
        }

        [JsiiProperty(name: "policyDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PolicyDurationSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftGameSessionQueuePlayerLatencyPolicy), fullyQualifiedName: "aws.GameliftGameSessionQueuePlayerLatencyPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.IGameliftGameSessionQueuePlayerLatencyPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "maximumIndividualPlayerLatencyMilliseconds", typeJson: "{\"primitive\":\"number\"}")]
            public double MaximumIndividualPlayerLatencyMilliseconds
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "policyDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PolicyDurationSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
