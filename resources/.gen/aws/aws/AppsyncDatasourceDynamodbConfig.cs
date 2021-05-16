using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppsyncDatasourceDynamodbConfig")]
    public class AppsyncDatasourceDynamodbConfig : aws.IAppsyncDatasourceDynamodbConfig
    {
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TableName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Region
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "useCallerCredentials", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? UseCallerCredentials
        {
            get;
            set;
        }
    }
}
