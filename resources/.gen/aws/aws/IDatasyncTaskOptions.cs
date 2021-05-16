using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDatasyncTaskOptions), fullyQualifiedName: "aws.DatasyncTaskOptions")]
    public interface IDatasyncTaskOptions
    {
        [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Atime
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bytesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BytesPerSecond
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Gid
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mtime
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "posixPermissions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PosixPermissions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "preserveDeletedFiles", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreserveDeletedFiles
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "preserveDevices", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreserveDevices
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uid
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "verifyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerifyMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncTaskOptions), fullyQualifiedName: "aws.DatasyncTaskOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IDatasyncTaskOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Atime
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bytesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BytesPerSecond
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Gid
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mtime
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "posixPermissions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PosixPermissions
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "preserveDeletedFiles", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreserveDeletedFiles
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "preserveDevices", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreserveDevices
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uid
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "verifyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerifyMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
