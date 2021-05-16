using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsParallelism), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsParallelism")]
    public interface IKinesisAnalyticsApplicationInputsParallelism
    {
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        double Count
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsParallelism), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsParallelism")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationInputsParallelism
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
            public double Count
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
