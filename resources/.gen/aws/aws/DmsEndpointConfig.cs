using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DmsEndpointConfig")]
    public class DmsEndpointConfig : aws.IDmsEndpointConfig
    {
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EndpointId
        {
            get;
            set;
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EndpointType
        {
            get;
            set;
        }

        [JsiiProperty(name: "engineName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EngineName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CertificateArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DatabaseName
        {
            get;
            set;
        }

        /// <summary>elasticsearch_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointElasticsearchSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDmsEndpointElasticsearchSettings[]? ElasticsearchSettings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "extraConnectionAttributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ExtraConnectionAttributes
        {
            get;
            set;
        }

        /// <summary>kafka_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kafkaSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointKafkaSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDmsEndpointKafkaSettings[]? KafkaSettings
        {
            get;
            set;
        }

        /// <summary>kinesis_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointKinesisSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDmsEndpointKinesisSettings[]? KinesisSettings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>mongodb_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mongodbSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointMongodbSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDmsEndpointMongodbSettings[]? MongodbSettings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Password
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>s3_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Settings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointS3Settings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDmsEndpointS3Settings[]? S3Settings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ServerName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ServiceAccessRole
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SslMode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Username
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
