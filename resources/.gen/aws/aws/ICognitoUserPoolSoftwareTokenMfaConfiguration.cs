using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolSoftwareTokenMfaConfiguration), fullyQualifiedName: "aws.CognitoUserPoolSoftwareTokenMfaConfiguration")]
    public interface ICognitoUserPoolSoftwareTokenMfaConfiguration
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolSoftwareTokenMfaConfiguration), fullyQualifiedName: "aws.CognitoUserPoolSoftwareTokenMfaConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolSoftwareTokenMfaConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Enabled
            {
                get => GetInstanceProperty<bool>()!;
            }
        }
    }
}
