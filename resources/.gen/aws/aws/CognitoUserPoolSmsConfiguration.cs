using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CognitoUserPoolSmsConfiguration")]
    public class CognitoUserPoolSmsConfiguration : aws.ICognitoUserPoolSmsConfiguration
    {
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ExternalId
        {
            get;
            set;
        }

        [JsiiProperty(name: "snsCallerArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SnsCallerArn
        {
            get;
            set;
        }
    }
}
