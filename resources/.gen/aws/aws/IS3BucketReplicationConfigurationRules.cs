using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRules), fullyQualifiedName: "aws.S3BucketReplicationConfigurationRules")]
    public interface IS3BucketReplicationConfigurationRules
    {
        /// <summary>destination block.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesDestination\"},\"kind\":\"array\"}}")]
        aws.IS3BucketReplicationConfigurationRulesDestination[] Destination
        {
            get;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        /// <summary>filter block.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketReplicationConfigurationRulesFilter[]? Filter
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_selection_criteria block.</summary>
        [JsiiProperty(name: "sourceSelectionCriteria", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesSourceSelectionCriteria\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria[]? SourceSelectionCriteria
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRules), fullyQualifiedName: "aws.S3BucketReplicationConfigurationRules")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketReplicationConfigurationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesDestination\"},\"kind\":\"array\"}}")]
            public aws.IS3BucketReplicationConfigurationRulesDestination[] Destination
            {
                get => GetInstanceProperty<aws.IS3BucketReplicationConfigurationRulesDestination[]>()!;
            }

            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketReplicationConfigurationRulesFilter[]? Filter
            {
                get => GetInstanceProperty<aws.IS3BucketReplicationConfigurationRulesFilter[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>source_selection_criteria block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceSelectionCriteria", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesSourceSelectionCriteria\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria[]? SourceSelectionCriteria
            {
                get => GetInstanceProperty<aws.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria[]?>();
            }
        }
    }
}
