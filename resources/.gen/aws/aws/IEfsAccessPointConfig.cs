using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEfsAccessPointConfig), fullyQualifiedName: "aws.EfsAccessPointConfig")]
    public interface IEfsAccessPointConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemId
        {
            get;
        }

        /// <summary>posix_user block.</summary>
        [JsiiProperty(name: "posixUser", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EfsAccessPointPosixUser\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEfsAccessPointPosixUser[]? PosixUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>root_directory block.</summary>
        [JsiiProperty(name: "rootDirectory", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EfsAccessPointRootDirectory\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEfsAccessPointRootDirectory[]? RootDirectory
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsAccessPointConfig), fullyQualifiedName: "aws.EfsAccessPointConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEfsAccessPointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>posix_user block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "posixUser", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EfsAccessPointPosixUser\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEfsAccessPointPosixUser[]? PosixUser
            {
                get => GetInstanceProperty<aws.IEfsAccessPointPosixUser[]?>();
            }

            /// <summary>root_directory block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootDirectory", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EfsAccessPointRootDirectory\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEfsAccessPointRootDirectory[]? RootDirectory
            {
                get => GetInstanceProperty<aws.IEfsAccessPointRootDirectory[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
