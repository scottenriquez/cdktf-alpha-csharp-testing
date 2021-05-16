using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolAdminCreateUserConfig), fullyQualifiedName: "aws.CognitoUserPoolAdminCreateUserConfig")]
    public interface ICognitoUserPoolAdminCreateUserConfig
    {
        [JsiiProperty(name: "allowAdminCreateUserOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllowAdminCreateUserOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>invite_message_template block.</summary>
        [JsiiProperty(name: "inviteMessageTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate[]? InviteMessageTemplate
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "unusedAccountValidityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UnusedAccountValidityDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolAdminCreateUserConfig), fullyQualifiedName: "aws.CognitoUserPoolAdminCreateUserConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolAdminCreateUserConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "allowAdminCreateUserOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllowAdminCreateUserOnly
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>invite_message_template block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inviteMessageTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate[]? InviteMessageTemplate
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "unusedAccountValidityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnusedAccountValidityDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
