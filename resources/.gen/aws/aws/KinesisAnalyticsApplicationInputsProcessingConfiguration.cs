using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationInputsProcessingConfiguration")]
    public class KinesisAnalyticsApplicationInputsProcessingConfiguration : aws.IKinesisAnalyticsApplicationInputsProcessingConfiguration
    {
        /// <summary>lambda block.</summary>
        [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsProcessingConfigurationLambda\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda[] Lambda
        {
            get;
            set;
        }
    }
}
