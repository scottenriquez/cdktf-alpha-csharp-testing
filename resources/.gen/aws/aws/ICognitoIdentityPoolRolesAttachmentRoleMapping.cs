using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentRoleMapping), fullyQualifiedName: "aws.CognitoIdentityPoolRolesAttachmentRoleMapping")]
    public interface ICognitoIdentityPoolRolesAttachmentRoleMapping
    {
        [JsiiProperty(name: "identityProvider", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityProvider
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "ambiguousRoleResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmbiguousRoleResolution
        {
            get
            {
                return null;
            }
        }

        /// <summary>mapping_rule block.</summary>
        [JsiiProperty(name: "mappingRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule[]? MappingRule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentRoleMapping), fullyQualifiedName: "aws.CognitoIdentityPoolRolesAttachmentRoleMapping")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoIdentityPoolRolesAttachmentRoleMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "identityProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityProvider
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "ambiguousRoleResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmbiguousRoleResolution
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>mapping_rule block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mappingRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule[]? MappingRule
            {
                get => GetInstanceProperty<aws.ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule[]?>();
            }
        }
    }
}
