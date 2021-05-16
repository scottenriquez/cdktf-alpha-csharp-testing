using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWorklinkFleetConfig), fullyQualifiedName: "aws.WorklinkFleetConfig")]
    public interface IWorklinkFleetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "auditStreamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuditStreamArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "deviceCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeviceCaCertificate
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity_provider block.</summary>
        [JsiiProperty(name: "identityProvider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorklinkFleetIdentityProvider\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWorklinkFleetIdentityProvider[]? IdentityProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>network block.</summary>
        [JsiiProperty(name: "network", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorklinkFleetNetwork\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWorklinkFleetNetwork[]? Network
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "optimizeForEndUserLocation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? OptimizeForEndUserLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorklinkFleetConfig), fullyQualifiedName: "aws.WorklinkFleetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IWorklinkFleetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "auditStreamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuditStreamArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "deviceCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceCaCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity_provider block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityProvider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorklinkFleetIdentityProvider\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWorklinkFleetIdentityProvider[]? IdentityProvider
            {
                get => GetInstanceProperty<aws.IWorklinkFleetIdentityProvider[]?>();
            }

            /// <summary>network block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorklinkFleetNetwork\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWorklinkFleetNetwork[]? Network
            {
                get => GetInstanceProperty<aws.IWorklinkFleetNetwork[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "optimizeForEndUserLocation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? OptimizeForEndUserLocation
            {
                get => GetInstanceProperty<bool?>();
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
