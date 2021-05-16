using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsGlueScriptDagNode), fullyQualifiedName: "aws.DataAwsGlueScriptDagNode")]
    public interface IDataAwsGlueScriptDagNode
    {
        /// <summary>args block.</summary>
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagNodeArgs\"},\"kind\":\"array\"}}")]
        aws.IDataAwsGlueScriptDagNodeArgs[] Args
        {
            get;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        string NodeType
        {
            get;
        }

        [JsiiProperty(name: "lineNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LineNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsGlueScriptDagNode), fullyQualifiedName: "aws.DataAwsGlueScriptDagNode")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsGlueScriptDagNode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>args block.</summary>
            [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagNodeArgs\"},\"kind\":\"array\"}}")]
            public aws.IDataAwsGlueScriptDagNodeArgs[] Args
            {
                get => GetInstanceProperty<aws.IDataAwsGlueScriptDagNodeArgs[]>()!;
            }

            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "lineNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LineNumber
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
