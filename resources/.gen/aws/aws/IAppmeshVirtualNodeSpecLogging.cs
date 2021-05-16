using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecLogging), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecLogging")]
    public interface IAppmeshVirtualNodeSpecLogging
    {
        /// <summary>access_log block.</summary>
        [JsiiProperty(name: "accessLog", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecLoggingAccessLog\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualNodeSpecLoggingAccessLog[]? AccessLog
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecLogging), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecLogging")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualNodeSpecLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_log block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessLog", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecLoggingAccessLog\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualNodeSpecLoggingAccessLog[]? AccessLog
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualNodeSpecLoggingAccessLog[]?>();
            }
        }
    }
}
