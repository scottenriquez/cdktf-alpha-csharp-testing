using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueCatalogTableStorageDescriptorSkewedInfo")]
    public class GlueCatalogTableStorageDescriptorSkewedInfo : aws.IGlueCatalogTableStorageDescriptorSkewedInfo
    {
        [JsiiOptional]
        [JsiiProperty(name: "skewedColumnNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SkewedColumnNames
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "skewedColumnValueLocationMaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? SkewedColumnValueLocationMaps
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "skewedColumnValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SkewedColumnValues
        {
            get;
            set;
        }
    }
}
