using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.DataAwsMqBrokerConfig")]
    public class DataAwsMqBrokerConfig : aws.IDataAwsMqBrokerConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "brokerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BrokerId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BrokerName
        {
            get;
            set;
        }

        /// <summary>logs block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsMqBrokerLogs\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDataAwsMqBrokerLogs[]? Logs
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
