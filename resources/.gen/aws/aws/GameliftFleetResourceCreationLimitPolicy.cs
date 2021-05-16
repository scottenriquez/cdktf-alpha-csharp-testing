using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GameliftFleetResourceCreationLimitPolicy")]
    public class GameliftFleetResourceCreationLimitPolicy : aws.IGameliftFleetResourceCreationLimitPolicy
    {
        [JsiiOptional]
        [JsiiProperty(name: "newGameSessionsPerCreator", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? NewGameSessionsPerCreator
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PolicyPeriodInMinutes
        {
            get;
            set;
        }
    }
}
