using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CognitoIdentityPoolRolesAttachmentRoleMapping")]
    public class CognitoIdentityPoolRolesAttachmentRoleMapping : aws.ICognitoIdentityPoolRolesAttachmentRoleMapping
    {
        [JsiiProperty(name: "identityProvider", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string IdentityProvider
        {
            get;
            set;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ambiguousRoleResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AmbiguousRoleResolution
        {
            get;
            set;
        }

        /// <summary>mapping_rule block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mappingRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule[]? MappingRule
        {
            get;
            set;
        }
    }
}
