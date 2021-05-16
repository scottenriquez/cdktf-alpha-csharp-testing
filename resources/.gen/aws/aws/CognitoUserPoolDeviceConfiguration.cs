using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CognitoUserPoolDeviceConfiguration")]
    public class CognitoUserPoolDeviceConfiguration : aws.ICognitoUserPoolDeviceConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "challengeRequiredOnNewDevice", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ChallengeRequiredOnNewDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceOnlyRememberedOnUserPrompt", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DeviceOnlyRememberedOnUserPrompt
        {
            get;
            set;
        }
    }
}
