using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamRedshiftConfiguration")]
    public class KinesisFirehoseDeliveryStreamRedshiftConfiguration : aws.IKinesisFirehoseDeliveryStreamRedshiftConfiguration
    {
        [JsiiProperty(name: "clusterJdbcurl", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClusterJdbcurl
        {
            get;
            set;
        }

        [JsiiProperty(name: "dataTableName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DataTableName
        {
            get;
            set;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Password
        {
            get;
            set;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Username
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CopyOptions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataTableColumns", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DataTableColumns
        {
            get;
            set;
        }

        /// <summary>processing_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfiguration[]? ProcessingConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RetryDuration
        {
            get;
            set;
        }

        /// <summary>s3_backup_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3BackupConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamRedshiftConfigurationS3BackupConfiguration[]? S3BackupConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3BackupMode
        {
            get;
            set;
        }
    }
}
