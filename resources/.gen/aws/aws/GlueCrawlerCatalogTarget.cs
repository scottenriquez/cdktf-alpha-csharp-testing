using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlueCrawlerCatalogTarget")]
    public class GlueCrawlerCatalogTarget : aws.IGlueCrawlerCatalogTarget
    {
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DatabaseName
        {
            get;
            set;
        }

        [JsiiProperty(name: "tables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Tables
        {
            get;
            set;
        }
    }
}
