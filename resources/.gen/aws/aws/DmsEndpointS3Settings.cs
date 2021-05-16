using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.DmsEndpointS3Settings")]
    public class DmsEndpointS3Settings : aws.IDmsEndpointS3Settings
    {
        [JsiiOptional]
        [JsiiProperty(name: "bucketFolder", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BucketFolder
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BucketName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CompressionType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "csvDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CsvDelimiter
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "csvRowDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CsvRowDelimiter
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalTableDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ExternalTableDefinition
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ServiceAccessRoleArn
        {
            get;
            set;
        }
    }
}
