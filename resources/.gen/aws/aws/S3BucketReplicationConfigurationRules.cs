using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketReplicationConfigurationRules")]
    public class S3BucketReplicationConfigurationRules : aws.IS3BucketReplicationConfigurationRules
    {
        /// <summary>destination block.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesDestination\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IS3BucketReplicationConfigurationRulesDestination[] Destination
        {
            get;
            set;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Status
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesFilter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketReplicationConfigurationRulesFilter[]? Filter
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Id
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Prefix
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>source_selection_criteria block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceSelectionCriteria", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesSourceSelectionCriteria\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria[]? SourceSelectionCriteria
        {
            get;
            set;
        }
    }
}
