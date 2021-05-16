using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAcmpcaCertificateAuthorityConfig), fullyQualifiedName: "aws.AcmpcaCertificateAuthorityConfig")]
    public interface IAcmpcaCertificateAuthorityConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>certificate_authority_configuration block.</summary>
        [JsiiProperty(name: "certificateAuthorityConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration\"},\"kind\":\"array\"}}")]
        aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration[] CertificateAuthorityConfiguration
        {
            get;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "permanentDeletionTimeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PermanentDeletionTimeInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>revocation_configuration block.</summary>
        [JsiiProperty(name: "revocationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityRevocationConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAcmpcaCertificateAuthorityRevocationConfiguration[]? RevocationConfiguration
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

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AcmpcaCertificateAuthorityTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAcmpcaCertificateAuthorityTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmpcaCertificateAuthorityConfig), fullyQualifiedName: "aws.AcmpcaCertificateAuthorityConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAcmpcaCertificateAuthorityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>certificate_authority_configuration block.</summary>
            [JsiiProperty(name: "certificateAuthorityConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration\"},\"kind\":\"array\"}}")]
            public aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration[] CertificateAuthorityConfiguration
            {
                get => GetInstanceProperty<aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "permanentDeletionTimeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PermanentDeletionTimeInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>revocation_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "revocationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityRevocationConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAcmpcaCertificateAuthorityRevocationConfiguration[]? RevocationConfiguration
            {
                get => GetInstanceProperty<aws.IAcmpcaCertificateAuthorityRevocationConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AcmpcaCertificateAuthorityTimeouts\"}", isOptional: true)]
            public aws.IAcmpcaCertificateAuthorityTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IAcmpcaCertificateAuthorityTimeouts?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
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
