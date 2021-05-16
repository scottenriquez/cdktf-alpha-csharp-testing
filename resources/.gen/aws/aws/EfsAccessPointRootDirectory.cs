using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.EfsAccessPointRootDirectory")]
    public class EfsAccessPointRootDirectory : aws.IEfsAccessPointRootDirectory
    {
        /// <summary>creation_info block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "creationInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EfsAccessPointRootDirectoryCreationInfo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEfsAccessPointRootDirectoryCreationInfo[]? CreationInfo
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
