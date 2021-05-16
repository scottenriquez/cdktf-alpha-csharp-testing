using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointS3Settings), fullyQualifiedName: "aws.DmsEndpointS3Settings")]
    public interface IDmsEndpointS3Settings
    {
        [JsiiProperty(name: "bucketFolder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketFolder
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompressionType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "csvDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CsvDelimiter
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "csvRowDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CsvRowDelimiter
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "externalTableDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalTableDefinition
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccessRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointS3Settings), fullyQualifiedName: "aws.DmsEndpointS3Settings")]
        internal sealed class _Proxy : DeputyBase, aws.IDmsEndpointS3Settings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "bucketFolder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketFolder
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompressionType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "csvDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CsvDelimiter
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "csvRowDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CsvRowDelimiter
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "externalTableDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalTableDefinition
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccessRoleArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
