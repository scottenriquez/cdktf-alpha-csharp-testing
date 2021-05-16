using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlueCatalogTableConfig")]
    public class GlueCatalogTableConfig : aws.IGlueCatalogTableConfig
    {
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DatabaseName
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CatalogId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Owner
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }

        /// <summary>partition_keys block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "partitionKeys", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTablePartitionKeys\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueCatalogTablePartitionKeys[]? PartitionKeys
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "retention", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Retention
        {
            get;
            set;
        }

        /// <summary>storage_descriptor block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageDescriptor", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptor\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueCatalogTableStorageDescriptor[]? StorageDescriptor
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TableType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewExpandedText", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ViewExpandedText
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewOriginalText", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ViewOriginalText
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
