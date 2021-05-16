using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppmeshVirtualNodeSpecBackend")]
    public class AppmeshVirtualNodeSpecBackend : aws.IAppmeshVirtualNodeSpecBackend
    {
        /// <summary>virtual_service block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualService", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecBackendVirtualService\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualNodeSpecBackendVirtualService[]? VirtualService
        {
            get;
            set;
        }
    }
}
