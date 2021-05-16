using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueCatalogTableStorageDescriptor")]
    public class GlueCatalogTableStorageDescriptor : aws.IGlueCatalogTableStorageDescriptor
    {
        [JsiiOptional]
        [JsiiProperty(name: "bucketColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? BucketColumns
        {
            get;
            set;
        }

        /// <summary>columns block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "columns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorColumns\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueCatalogTableStorageDescriptorColumns[]? Columns
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressed", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Compressed
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InputFormat
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Location
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? NumberOfBuckets
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OutputFormat
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

        /// <summary>ser_de_info block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serDeInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorSerDeInfo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueCatalogTableStorageDescriptorSerDeInfo[]? SerDeInfo
        {
            get;
            set;
        }

        /// <summary>skewed_info block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skewedInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorSkewedInfo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueCatalogTableStorageDescriptorSkewedInfo[]? SkewedInfo
        {
            get;
            set;
        }

        /// <summary>sort_columns block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sortColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorSortColumns\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueCatalogTableStorageDescriptorSortColumns[]? SortColumns
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "storedAsSubDirectories", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? StoredAsSubDirectories
        {
            get;
            set;
        }
    }
}
