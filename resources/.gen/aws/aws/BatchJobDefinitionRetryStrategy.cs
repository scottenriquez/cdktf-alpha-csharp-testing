using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.BatchJobDefinitionRetryStrategy")]
    public class BatchJobDefinitionRetryStrategy : aws.IBatchJobDefinitionRetryStrategy
    {
        [JsiiOptional]
        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Attempts
        {
            get;
            set;
        }
    }
}
