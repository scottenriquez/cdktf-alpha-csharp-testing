using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableStorageDescriptorSkewedInfo), fullyQualifiedName: "aws.GlueCatalogTableStorageDescriptorSkewedInfo")]
    public interface IGlueCatalogTableStorageDescriptorSkewedInfo
    {
        [JsiiProperty(name: "skewedColumnNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SkewedColumnNames
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "skewedColumnValueLocationMaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? SkewedColumnValueLocationMaps
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "skewedColumnValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SkewedColumnValues
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableStorageDescriptorSkewedInfo), fullyQualifiedName: "aws.GlueCatalogTableStorageDescriptorSkewedInfo")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueCatalogTableStorageDescriptorSkewedInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "skewedColumnNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SkewedColumnNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "skewedColumnValueLocationMaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? SkewedColumnValueLocationMaps
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "skewedColumnValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SkewedColumnValues
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
