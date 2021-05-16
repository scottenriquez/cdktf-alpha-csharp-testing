using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolDeviceConfiguration), fullyQualifiedName: "aws.CognitoUserPoolDeviceConfiguration")]
    public interface ICognitoUserPoolDeviceConfiguration
    {
        [JsiiProperty(name: "challengeRequiredOnNewDevice", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ChallengeRequiredOnNewDevice
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "deviceOnlyRememberedOnUserPrompt", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DeviceOnlyRememberedOnUserPrompt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolDeviceConfiguration), fullyQualifiedName: "aws.CognitoUserPoolDeviceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolDeviceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "challengeRequiredOnNewDevice", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ChallengeRequiredOnNewDevice
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "deviceOnlyRememberedOnUserPrompt", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DeviceOnlyRememberedOnUserPrompt
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
