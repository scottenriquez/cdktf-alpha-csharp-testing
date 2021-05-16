using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.ServiceDiscoveryService), fullyQualifiedName: "aws.ServiceDiscoveryService", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ServiceDiscoveryServiceConfig\"}}]")]
    public class ServiceDiscoveryService : HashiCorp.Cdktf.TerraformResource
    {
        public ServiceDiscoveryService(Constructs.Construct scope, string id, aws.IServiceDiscoveryServiceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryService(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsConfig")]
        public virtual void ResetDnsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckConfig")]
        public virtual void ResetHealthCheckConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckCustomConfig")]
        public virtual void ResetHealthCheckCustomConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamespaceId")]
        public virtual void ResetNamespaceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
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

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceDnsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IServiceDiscoveryServiceDnsConfig[]? DnsConfigInput
        {
            get => GetInstanceProperty<aws.IServiceDiscoveryServiceDnsConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceHealthCheckConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IServiceDiscoveryServiceHealthCheckConfig[]? HealthCheckConfigInput
        {
            get => GetInstanceProperty<aws.IServiceDiscoveryServiceHealthCheckConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckCustomConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceHealthCheckCustomConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IServiceDiscoveryServiceHealthCheckCustomConfig[]? HealthCheckCustomConfigInput
        {
            get => GetInstanceProperty<aws.IServiceDiscoveryServiceHealthCheckCustomConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dnsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceDnsConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IServiceDiscoveryServiceDnsConfig[] DnsConfig
        {
            get => GetInstanceProperty<aws.IServiceDiscoveryServiceDnsConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceHealthCheckConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IServiceDiscoveryServiceHealthCheckConfig[] HealthCheckConfig
        {
            get => GetInstanceProperty<aws.IServiceDiscoveryServiceHealthCheckConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckCustomConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceHealthCheckCustomConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IServiceDiscoveryServiceHealthCheckCustomConfig[] HealthCheckCustomConfig
        {
            get => GetInstanceProperty<aws.IServiceDiscoveryServiceHealthCheckCustomConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamespaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
