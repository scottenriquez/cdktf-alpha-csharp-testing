using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolClientAnalyticsConfiguration), fullyQualifiedName: "aws.CognitoUserPoolClientAnalyticsConfiguration")]
    public interface ICognitoUserPoolClientAnalyticsConfiguration
    {
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationId
        {
            get;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalId
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "userDataShared", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? UserDataShared
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolClientAnalyticsConfiguration), fullyQualifiedName: "aws.CognitoUserPoolClientAnalyticsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolClientAnalyticsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "userDataShared", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? UserDataShared
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
