using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GameliftGameSessionQueuePlayerLatencyPolicy")]
    public class GameliftGameSessionQueuePlayerLatencyPolicy : aws.IGameliftGameSessionQueuePlayerLatencyPolicy
    {
        [JsiiProperty(name: "maximumIndividualPlayerLatencyMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaximumIndividualPlayerLatencyMilliseconds
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PolicyDurationSeconds
        {
            get;
            set;
        }
    }
}
