using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AlbListenerTimeouts")]
    public class AlbListenerTimeouts : aws.IAlbListenerTimeouts
    {
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
