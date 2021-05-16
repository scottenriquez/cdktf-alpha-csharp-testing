using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AlbListenerDefaultActionRedirect")]
    public class AlbListenerDefaultActionRedirect : aws.IAlbListenerDefaultActionRedirect
    {
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StatusCode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Host
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Path
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Port
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Protocol
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Query
        {
            get;
            set;
        }
    }
}
