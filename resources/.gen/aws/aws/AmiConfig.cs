using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AmiConfig")]
    public class AmiConfig : aws.IAmiConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Architecture
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>ebs_block_device block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAmiEbsBlockDevice[]? EbsBlockDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enaSupport", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnaSupport
        {
            get;
            set;
        }

        /// <summary>ephemeral_block_device block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAmiEphemeralBlockDevice[]? EphemeralBlockDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ImageLocation
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KernelId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ramdiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RamdiskId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RootDeviceName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sriovNetSupport", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SriovNetSupport
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AmiTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IAmiTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VirtualizationType
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
