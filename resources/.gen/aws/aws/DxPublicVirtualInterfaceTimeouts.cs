using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.DxPublicVirtualInterfaceTimeouts")]
    public class DxPublicVirtualInterfaceTimeouts : aws.IDxPublicVirtualInterfaceTimeouts
    {
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Create
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}