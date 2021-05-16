using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueJobExecutionProperty")]
    public class GlueJobExecutionProperty : aws.IGlueJobExecutionProperty
    {
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxConcurrentRuns
        {
            get;
            set;
        }
    }
}
