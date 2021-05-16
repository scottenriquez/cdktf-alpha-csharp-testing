using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEfsAccessPointRootDirectory), fullyQualifiedName: "aws.EfsAccessPointRootDirectory")]
    public interface IEfsAccessPointRootDirectory
    {
        /// <summary>creation_info block.</summary>
        [JsiiProperty(name: "creationInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EfsAccessPointRootDirectoryCreationInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEfsAccessPointRootDirectoryCreationInfo[]? CreationInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsAccessPointRootDirectory), fullyQualifiedName: "aws.EfsAccessPointRootDirectory")]
        internal sealed class _Proxy : DeputyBase, aws.IEfsAccessPointRootDirectory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>creation_info block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "creationInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EfsAccessPointRootDirectoryCreationInfo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEfsAccessPointRootDirectoryCreationInfo[]? CreationInfo
            {
                get => GetInstanceProperty<aws.IEfsAccessPointRootDirectoryCreationInfo[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
