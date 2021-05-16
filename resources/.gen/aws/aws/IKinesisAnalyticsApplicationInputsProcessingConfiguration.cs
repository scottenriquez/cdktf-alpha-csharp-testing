using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsProcessingConfiguration), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsProcessingConfiguration")]
    public interface IKinesisAnalyticsApplicationInputsProcessingConfiguration
    {
        /// <summary>lambda block.</summary>
        [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsProcessingConfigurationLambda\"},\"kind\":\"array\"}}")]
        aws.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda[] Lambda
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsProcessingConfiguration), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsProcessingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationInputsProcessingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>lambda block.</summary>
            [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsProcessingConfigurationLambda\"},\"kind\":\"array\"}}")]
            public aws.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda[] Lambda
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda[]>()!;
            }
        }
    }
}
