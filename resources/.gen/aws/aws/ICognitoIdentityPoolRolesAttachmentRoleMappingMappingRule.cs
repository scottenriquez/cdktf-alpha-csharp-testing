using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule), fullyQualifiedName: "aws.CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule")]
    public interface ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule
    {
        [JsiiProperty(name: "claim", typeJson: "{\"primitive\":\"string\"}")]
        string Claim
        {
            get;
        }

        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}")]
        string MatchType
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule), fullyQualifiedName: "aws.CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "claim", typeJson: "{\"primitive\":\"string\"}")]
            public string Claim
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}")]
            public string MatchType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
