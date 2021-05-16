using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IPinpointAppCampaignHook), fullyQualifiedName: "aws.PinpointAppCampaignHook")]
    public interface IPinpointAppCampaignHook
    {
        [JsiiProperty(name: "lambdaFunctionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LambdaFunctionName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "webUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPinpointAppCampaignHook), fullyQualifiedName: "aws.PinpointAppCampaignHook")]
        internal sealed class _Proxy : DeputyBase, aws.IPinpointAppCampaignHook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LambdaFunctionName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "webUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
