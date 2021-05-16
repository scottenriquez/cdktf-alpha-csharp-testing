using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointMongodbSettings), fullyQualifiedName: "aws.DmsEndpointMongodbSettings")]
    public interface IDmsEndpointMongodbSettings
    {
        [JsiiProperty(name: "authMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthMechanism
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "authSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthSource
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "docsToInvestigate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DocsToInvestigate
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "extractDocId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExtractDocId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "nestingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NestingLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointMongodbSettings), fullyQualifiedName: "aws.DmsEndpointMongodbSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IDmsEndpointMongodbSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "authMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthMechanism
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "authSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthSource
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "docsToInvestigate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DocsToInvestigate
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "extractDocId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExtractDocId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "nestingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NestingLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
