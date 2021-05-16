using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GameliftFleetRuntimeConfigurationServerProcess")]
    public class GameliftFleetRuntimeConfigurationServerProcess : aws.IGameliftFleetRuntimeConfigurationServerProcess
    {
        [JsiiProperty(name: "concurrentExecutions", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ConcurrentExecutions
        {
            get;
            set;
        }

        [JsiiProperty(name: "launchPath", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LaunchPath
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Parameters
        {
            get;
            set;
        }
    }
}
