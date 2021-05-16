using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueJobCommand), fullyQualifiedName: "aws.GlueJobCommand")]
    public interface IGlueJobCommand
    {
        [JsiiProperty(name: "scriptLocation", typeJson: "{\"primitive\":\"string\"}")]
        string ScriptLocation
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PythonVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueJobCommand), fullyQualifiedName: "aws.GlueJobCommand")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueJobCommand
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "scriptLocation", typeJson: "{\"primitive\":\"string\"}")]
            public string ScriptLocation
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PythonVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
