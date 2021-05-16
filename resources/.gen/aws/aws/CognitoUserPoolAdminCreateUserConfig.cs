using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CognitoUserPoolAdminCreateUserConfig")]
    public class CognitoUserPoolAdminCreateUserConfig : aws.ICognitoUserPoolAdminCreateUserConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "allowAdminCreateUserOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowAdminCreateUserOnly
        {
            get;
            set;
        }

        /// <summary>invite_message_template block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inviteMessageTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate[]? InviteMessageTemplate
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "unusedAccountValidityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? UnusedAccountValidityDays
        {
            get;
            set;
        }
    }
}
