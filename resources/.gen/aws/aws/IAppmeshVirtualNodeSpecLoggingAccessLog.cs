using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecLoggingAccessLog), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecLoggingAccessLog")]
    public interface IAppmeshVirtualNodeSpecLoggingAccessLog
    {
        /// <summary>file block.</summary>
        [JsiiProperty(name: "file", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecLoggingAccessLogFile\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualNodeSpecLoggingAccessLogFile[]? File
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecLoggingAccessLog), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecLoggingAccessLog")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualNodeSpecLoggingAccessLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>file block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecLoggingAccessLogFile\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualNodeSpecLoggingAccessLogFile[]? File
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualNodeSpecLoggingAccessLogFile[]?>();
            }
        }
    }
}
