using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DataAwsKmsSecretsSecret")]
    public class DataAwsKmsSecretsSecret : aws.IDataAwsKmsSecretsSecret
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Payload
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "context", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Context
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantTokens", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? GrantTokens
        {
            get;
            set;
        }
    }
}
