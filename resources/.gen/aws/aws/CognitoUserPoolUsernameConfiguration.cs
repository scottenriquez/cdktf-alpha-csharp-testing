using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CognitoUserPoolUsernameConfiguration")]
    public class CognitoUserPoolUsernameConfiguration : aws.ICognitoUserPoolUsernameConfiguration
    {
        [JsiiProperty(name: "caseSensitive", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool CaseSensitive
        {
            get;
            set;
        }
    }
}
