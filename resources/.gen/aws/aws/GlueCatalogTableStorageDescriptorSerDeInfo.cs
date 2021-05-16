using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueCatalogTableStorageDescriptorSerDeInfo")]
    public class GlueCatalogTableStorageDescriptorSerDeInfo : aws.IGlueCatalogTableStorageDescriptorSerDeInfo
    {
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
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

        [JsiiOptional]
        [JsiiProperty(name: "serializationLibrary", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SerializationLibrary
        {
            get;
            set;
        }
    }
}
