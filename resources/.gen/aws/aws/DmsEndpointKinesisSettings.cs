using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.DmsEndpointKinesisSettings")]
    public class DmsEndpointKinesisSettings : aws.IDmsEndpointKinesisSettings
    {
        [JsiiOptional]
        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MessageFormat
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

        [JsiiOptional]
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StreamArn
        {
            get;
            set;
        }
    }
}
