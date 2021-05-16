using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentConfig), fullyQualifiedName: "aws.CognitoIdentityPoolRolesAttachmentConfig")]
    public interface ICognitoIdentityPoolRolesAttachmentConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityPoolId
        {
            get;
        }

        [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Roles
        {
            get;
        }

        /// <summary>role_mapping block.</summary>
        [JsiiProperty(name: "roleMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoIdentityPoolRolesAttachmentRoleMapping\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoIdentityPoolRolesAttachmentRoleMapping[]? RoleMapping
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentConfig), fullyQualifiedName: "aws.CognitoIdentityPoolRolesAttachmentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoIdentityPoolRolesAttachmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Roles
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>role_mapping block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoIdentityPoolRolesAttachmentRoleMapping\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoIdentityPoolRolesAttachmentRoleMapping[]? RoleMapping
            {
                get => GetInstanceProperty<aws.ICognitoIdentityPoolRolesAttachmentRoleMapping[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
