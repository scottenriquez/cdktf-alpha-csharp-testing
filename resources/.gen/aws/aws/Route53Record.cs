using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.Route53Record), fullyQualifiedName: "aws.Route53Record", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.Route53RecordConfig\"}}]")]
    public class Route53Record : HashiCorp.Cdktf.TerraformResource
    {
        public Route53Record(Constructs.Construct scope, string id, aws.IRoute53RecordConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53Record(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53Record(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowOverwrite")]
        public virtual void ResetAllowOverwrite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailoverRoutingPolicy")]
        public virtual void ResetFailoverRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeolocationRoutingPolicy")]
        public virtual void ResetGeolocationRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckId")]
        public virtual void ResetHealthCheckId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLatencyRoutingPolicy")]
        public virtual void ResetLatencyRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMultivalueAnswerRoutingPolicy")]
        public virtual void ResetMultivalueAnswerRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecords")]
        public virtual void ResetRecords()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetIdentifier")]
        public virtual void ResetSetIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTtl")]
        public virtual void ResetTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeightedRoutingPolicy")]
        public virtual void ResetWeightedRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zoneIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordAlias\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IRoute53RecordAlias[]? AliasInput
        {
            get => GetInstanceProperty<aws.IRoute53RecordAlias[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowOverwriteInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? AllowOverwriteInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failoverRoutingPolicyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordFailoverRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IRoute53RecordFailoverRoutingPolicy[]? FailoverRoutingPolicyInput
        {
            get => GetInstanceProperty<aws.IRoute53RecordFailoverRoutingPolicy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geolocationRoutingPolicyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordGeolocationRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IRoute53RecordGeolocationRoutingPolicy[]? GeolocationRoutingPolicyInput
        {
            get => GetInstanceProperty<aws.IRoute53RecordGeolocationRoutingPolicy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "latencyRoutingPolicyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordLatencyRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IRoute53RecordLatencyRoutingPolicy[]? LatencyRoutingPolicyInput
        {
            get => GetInstanceProperty<aws.IRoute53RecordLatencyRoutingPolicy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "multivalueAnswerRoutingPolicyInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? MultivalueAnswerRoutingPolicyInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RecordsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SetIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weightedRoutingPolicyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordWeightedRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IRoute53RecordWeightedRoutingPolicy[]? WeightedRoutingPolicyInput
        {
            get => GetInstanceProperty<aws.IRoute53RecordWeightedRoutingPolicy[]?>();
        }

        [JsiiProperty(name: "alias", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordAlias\"},\"kind\":\"array\"}}")]
        public virtual aws.IRoute53RecordAlias[] Alias
        {
            get => GetInstanceProperty<aws.IRoute53RecordAlias[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowOverwrite", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AllowOverwrite
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "failoverRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordFailoverRoutingPolicy\"},\"kind\":\"array\"}}")]
        public virtual aws.IRoute53RecordFailoverRoutingPolicy[] FailoverRoutingPolicy
        {
            get => GetInstanceProperty<aws.IRoute53RecordFailoverRoutingPolicy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "geolocationRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordGeolocationRoutingPolicy\"},\"kind\":\"array\"}}")]
        public virtual aws.IRoute53RecordGeolocationRoutingPolicy[] GeolocationRoutingPolicy
        {
            get => GetInstanceProperty<aws.IRoute53RecordGeolocationRoutingPolicy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "latencyRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordLatencyRoutingPolicy\"},\"kind\":\"array\"}}")]
        public virtual aws.IRoute53RecordLatencyRoutingPolicy[] LatencyRoutingPolicy
        {
            get => GetInstanceProperty<aws.IRoute53RecordLatencyRoutingPolicy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "multivalueAnswerRoutingPolicy", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool MultivalueAnswerRoutingPolicy
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "records", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Records
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ttl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weightedRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordWeightedRoutingPolicy\"},\"kind\":\"array\"}}")]
        public virtual aws.IRoute53RecordWeightedRoutingPolicy[] WeightedRoutingPolicy
        {
            get => GetInstanceProperty<aws.IRoute53RecordWeightedRoutingPolicy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
