using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsGlueScriptDagNodeArgs), fullyQualifiedName: "aws.DataAwsGlueScriptDagNodeArgs")]
    public interface IDataAwsGlueScriptDagNodeArgs
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiProperty(name: "param", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Param
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsGlueScriptDagNodeArgs), fullyQualifiedName: "aws.DataAwsGlueScriptDagNodeArgs")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsGlueScriptDagNodeArgs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "param", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Param
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
