using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableStorageDescriptor), fullyQualifiedName: "aws.GlueCatalogTableStorageDescriptor")]
    public interface IGlueCatalogTableStorageDescriptor
    {
        [JsiiProperty(name: "bucketColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BucketColumns
        {
            get
            {
                return null;
            }
        }

        /// <summary>columns block.</summary>
        [JsiiProperty(name: "columns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorColumns\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueCatalogTableStorageDescriptorColumns[]? Columns
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "compressed", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Compressed
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputFormat
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "numberOfBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumberOfBuckets
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputFormat
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>ser_de_info block.</summary>
        [JsiiProperty(name: "serDeInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorSerDeInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueCatalogTableStorageDescriptorSerDeInfo[]? SerDeInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>skewed_info block.</summary>
        [JsiiProperty(name: "skewedInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorSkewedInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueCatalogTableStorageDescriptorSkewedInfo[]? SkewedInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>sort_columns block.</summary>
        [JsiiProperty(name: "sortColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorSortColumns\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueCatalogTableStorageDescriptorSortColumns[]? SortColumns
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "storedAsSubDirectories", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? StoredAsSubDirectories
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableStorageDescriptor), fullyQualifiedName: "aws.GlueCatalogTableStorageDescriptor")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueCatalogTableStorageDescriptor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "bucketColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BucketColumns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>columns block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "columns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorColumns\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueCatalogTableStorageDescriptorColumns[]? Columns
            {
                get => GetInstanceProperty<aws.IGlueCatalogTableStorageDescriptorColumns[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "compressed", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Compressed
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputFormat
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "numberOfBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumberOfBuckets
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputFormat
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>ser_de_info block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serDeInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorSerDeInfo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueCatalogTableStorageDescriptorSerDeInfo[]? SerDeInfo
            {
                get => GetInstanceProperty<aws.IGlueCatalogTableStorageDescriptorSerDeInfo[]?>();
            }

            /// <summary>skewed_info block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skewedInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorSkewedInfo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueCatalogTableStorageDescriptorSkewedInfo[]? SkewedInfo
            {
                get => GetInstanceProperty<aws.IGlueCatalogTableStorageDescriptorSkewedInfo[]?>();
            }

            /// <summary>sort_columns block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sortColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptorSortColumns\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueCatalogTableStorageDescriptorSortColumns[]? SortColumns
            {
                get => GetInstanceProperty<aws.IGlueCatalogTableStorageDescriptorSortColumns[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "storedAsSubDirectories", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? StoredAsSubDirectories
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
