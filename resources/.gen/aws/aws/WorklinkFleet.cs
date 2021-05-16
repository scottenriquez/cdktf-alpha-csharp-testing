using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WorklinkFleet), fullyQualifiedName: "aws.WorklinkFleet", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WorklinkFleetConfig\"}}]")]
    public class WorklinkFleet : HashiCorp.Cdktf.TerraformResource
    {
        public WorklinkFleet(Constructs.Construct scope, string id, aws.IWorklinkFleetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorklinkFleet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorklinkFleet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAuditStreamArn")]
        public virtual void ResetAuditStreamArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceCaCertificate")]
        public virtual void ResetDeviceCaCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityProvider")]
        public virtual void ResetIdentityProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetwork")]
        public virtual void ResetNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOptimizeForEndUserLocation")]
        public virtual void ResetOptimizeForEndUserLocation()
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

        [JsiiProperty(name: "companyCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompanyCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastUpdatedTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdatedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditStreamArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuditStreamArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceCaCertificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceCaCertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityProviderInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorklinkFleetIdentityProvider\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWorklinkFleetIdentityProvider[]? IdentityProviderInput
        {
            get => GetInstanceProperty<aws.IWorklinkFleetIdentityProvider[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorklinkFleetNetwork\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWorklinkFleetNetwork[]? NetworkInput
        {
            get => GetInstanceProperty<aws.IWorklinkFleetNetwork[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "optimizeForEndUserLocationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? OptimizeForEndUserLocationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "auditStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditStreamArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceCaCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceCaCertificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identityProvider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorklinkFleetIdentityProvider\"},\"kind\":\"array\"}}")]
        public virtual aws.IWorklinkFleetIdentityProvider[] IdentityProvider
        {
            get => GetInstanceProperty<aws.IWorklinkFleetIdentityProvider[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "network", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorklinkFleetNetwork\"},\"kind\":\"array\"}}")]
        public virtual aws.IWorklinkFleetNetwork[] Network
        {
            get => GetInstanceProperty<aws.IWorklinkFleetNetwork[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "optimizeForEndUserLocation", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool OptimizeForEndUserLocation
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }
    }
}
