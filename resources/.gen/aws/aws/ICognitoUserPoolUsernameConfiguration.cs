using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolUsernameConfiguration), fullyQualifiedName: "aws.CognitoUserPoolUsernameConfiguration")]
    public interface ICognitoUserPoolUsernameConfiguration
    {
        [JsiiProperty(name: "caseSensitive", typeJson: "{\"primitive\":\"boolean\"}")]
        bool CaseSensitive
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolUsernameConfiguration), fullyQualifiedName: "aws.CognitoUserPoolUsernameConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolUsernameConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "caseSensitive", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool CaseSensitive
            {
                get => GetInstanceProperty<bool>()!;
            }
        }
    }
}
