using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.DatasyncTaskOptions")]
    public class DatasyncTaskOptions : aws.IDatasyncTaskOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Atime
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bytesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BytesPerSecond
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Gid
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Mtime
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "posixPermissions", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PosixPermissions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preserveDeletedFiles", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PreserveDeletedFiles
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preserveDevices", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PreserveDevices
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Uid
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VerifyMode
        {
            get;
            set;
        }
    }
}
