using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoResourceServerScope), fullyQualifiedName: "aws.CognitoResourceServerScope")]
    public interface ICognitoResourceServerScope
    {
        [JsiiProperty(name: "scopeDescription", typeJson: "{\"primitive\":\"string\"}")]
        string ScopeDescription
        {
            get;
        }

        [JsiiProperty(name: "scopeName", typeJson: "{\"primitive\":\"string\"}")]
        string ScopeName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoResourceServerScope), fullyQualifiedName: "aws.CognitoResourceServerScope")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoResourceServerScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "scopeDescription", typeJson: "{\"primitive\":\"string\"}")]
            public string ScopeDescription
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "scopeName", typeJson: "{\"primitive\":\"string\"}")]
            public string ScopeName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
