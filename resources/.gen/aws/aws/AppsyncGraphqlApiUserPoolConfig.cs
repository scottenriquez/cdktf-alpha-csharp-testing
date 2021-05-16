using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppsyncGraphqlApiUserPoolConfig")]
    public class AppsyncGraphqlApiUserPoolConfig : aws.IAppsyncGraphqlApiUserPoolConfig
    {
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DefaultAction
        {
            get;
            set;
        }

        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserPoolId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appIdClientRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AppIdClientRegex
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AwsRegion
        {
            get;
            set;
        }
    }
}
