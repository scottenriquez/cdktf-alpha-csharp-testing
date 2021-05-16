using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule")]
    public class CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule : aws.ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule
    {
        [JsiiProperty(name: "claim", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Claim
        {
            get;
            set;
        }

        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MatchType
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

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Value
        {
            get;
            set;
        }
    }
}
