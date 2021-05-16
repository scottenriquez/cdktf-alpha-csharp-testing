using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISesReceiptRuleAddHeaderAction), fullyQualifiedName: "aws.SesReceiptRuleAddHeaderAction")]
    public interface ISesReceiptRuleAddHeaderAction
    {
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        string HeaderName
        {
            get;
        }

        [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}")]
        string HeaderValue
        {
            get;
        }

        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
        double Position
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesReceiptRuleAddHeaderAction), fullyQualifiedName: "aws.SesReceiptRuleAddHeaderAction")]
        internal sealed class _Proxy : DeputyBase, aws.ISesReceiptRuleAddHeaderAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
            public string HeaderName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}")]
            public string HeaderValue
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
            public double Position
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
