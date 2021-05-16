using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CognitoUserPoolClientAnalyticsConfiguration")]
    public class CognitoUserPoolClientAnalyticsConfiguration : aws.ICognitoUserPoolClientAnalyticsConfiguration
    {
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ApplicationId
        {
            get;
            set;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ExternalId
        {
            get;
            set;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDataShared", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? UserDataShared
        {
            get;
            set;
        }
    }
}
