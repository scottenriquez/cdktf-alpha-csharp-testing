using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.DmsEndpointMongodbSettings")]
    public class DmsEndpointMongodbSettings : aws.IDmsEndpointMongodbSettings
    {
        [JsiiOptional]
        [JsiiProperty(name: "authMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AuthMechanism
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AuthSource
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AuthType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "docsToInvestigate", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DocsToInvestigate
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "extractDocId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ExtractDocId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nestingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NestingLevel
        {
            get;
            set;
        }
    }
}
