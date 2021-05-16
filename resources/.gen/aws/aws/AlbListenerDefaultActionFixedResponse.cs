using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AlbListenerDefaultActionFixedResponse")]
    public class AlbListenerDefaultActionFixedResponse : aws.IAlbListenerDefaultActionFixedResponse
    {
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ContentType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MessageBody
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StatusCode
        {
            get;
            set;
        }
    }
}
