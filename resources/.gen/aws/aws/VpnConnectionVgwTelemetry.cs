using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.VpnConnectionVgwTelemetry), fullyQualifiedName: "aws.VpnConnectionVgwTelemetry", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpnConnectionVgwTelemetry : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public VpnConnectionVgwTelemetry(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnConnectionVgwTelemetry(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnConnectionVgwTelemetry(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "acceptedRouteCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AcceptedRouteCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lastStatusChange", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastStatusChange
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outsideIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutsideIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusMessage
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
