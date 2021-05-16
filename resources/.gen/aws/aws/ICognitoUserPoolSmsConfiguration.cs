using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolSmsConfiguration), fullyQualifiedName: "aws.CognitoUserPoolSmsConfiguration")]
    public interface ICognitoUserPoolSmsConfiguration
    {
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalId
        {
            get;
        }

        [JsiiProperty(name: "snsCallerArn", typeJson: "{\"primitive\":\"string\"}")]
        string SnsCallerArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolSmsConfiguration), fullyQualifiedName: "aws.CognitoUserPoolSmsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolSmsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "snsCallerArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SnsCallerArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
