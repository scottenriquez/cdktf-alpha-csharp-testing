using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IRedshiftEventSubscriptionConfig), fullyQualifiedName: "aws.RedshiftEventSubscriptionConfig")]
    public interface IRedshiftEventSubscriptionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        string SnsTopicArn
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

        [JsiiProperty(name: "eventCategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EventCategories
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Severity
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourceIds
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceType
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.RedshiftEventSubscriptionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IRedshiftEventSubscriptionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftEventSubscriptionConfig), fullyQualifiedName: "aws.RedshiftEventSubscriptionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IRedshiftEventSubscriptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SnsTopicArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "eventCategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EventCategories
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Severity
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourceIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.RedshiftEventSubscriptionTimeouts\"}", isOptional: true)]
            public aws.IRedshiftEventSubscriptionTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IRedshiftEventSubscriptionTimeouts?>();
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
