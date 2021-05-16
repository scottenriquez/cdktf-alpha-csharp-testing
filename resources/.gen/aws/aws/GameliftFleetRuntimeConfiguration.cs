using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GameliftFleetRuntimeConfiguration")]
    public class GameliftFleetRuntimeConfiguration : aws.IGameliftFleetRuntimeConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "gameSessionActivationTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? GameSessionActivationTimeoutSeconds
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentGameSessionActivations", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxConcurrentGameSessionActivations
        {
            get;
            set;
        }

        /// <summary>server_process block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverProcess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetRuntimeConfigurationServerProcess\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGameliftFleetRuntimeConfigurationServerProcess[]? ServerProcess
        {
            get;
            set;
        }
    }
}
