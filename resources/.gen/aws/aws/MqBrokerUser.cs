using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MqBrokerUser")]
    public class MqBrokerUser : aws.IMqBrokerUser
    {
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Password
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

        [JsiiOptional]
        [JsiiProperty(name: "consoleAccess", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ConsoleAccess
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Groups
        {
            get;
            set;
        }
    }
}
