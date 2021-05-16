using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IOrganizationsAccountConfig), fullyQualifiedName: "aws.OrganizationsAccountConfig")]
    public interface IOrganizationsAccountConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        string Email
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "iamUserAccessToBilling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IamUserAccessToBilling
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParentId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOrganizationsAccountConfig), fullyQualifiedName: "aws.OrganizationsAccountConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IOrganizationsAccountConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
            public string Email
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "iamUserAccessToBilling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamUserAccessToBilling
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParentId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
