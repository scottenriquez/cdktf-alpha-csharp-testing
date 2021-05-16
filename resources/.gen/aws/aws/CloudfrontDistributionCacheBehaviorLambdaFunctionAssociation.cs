using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionCacheBehaviorLambdaFunctionAssociation")]
    public class CloudfrontDistributionCacheBehaviorLambdaFunctionAssociation : aws.ICloudfrontDistributionCacheBehaviorLambdaFunctionAssociation
    {
        [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EventType
        {
            get;
            set;
        }

        [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LambdaArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeBody", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeBody
        {
            get;
            set;
        }
    }
}
