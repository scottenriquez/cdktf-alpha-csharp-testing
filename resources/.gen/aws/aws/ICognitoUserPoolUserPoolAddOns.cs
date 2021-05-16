using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolUserPoolAddOns), fullyQualifiedName: "aws.CognitoUserPoolUserPoolAddOns")]
    public interface ICognitoUserPoolUserPoolAddOns
    {
        [JsiiProperty(name: "advancedSecurityMode", typeJson: "{\"primitive\":\"string\"}")]
        string AdvancedSecurityMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolUserPoolAddOns), fullyQualifiedName: "aws.CognitoUserPoolUserPoolAddOns")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolUserPoolAddOns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "advancedSecurityMode", typeJson: "{\"primitive\":\"string\"}")]
            public string AdvancedSecurityMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
