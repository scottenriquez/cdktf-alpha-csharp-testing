using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AcmpcaCertificateAuthority), fullyQualifiedName: "aws.AcmpcaCertificateAuthority", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityConfig\"}}]")]
    public class AcmpcaCertificateAuthority : HashiCorp.Cdktf.TerraformResource
    {
        public AcmpcaCertificateAuthority(Constructs.Construct scope, string id, aws.IAcmpcaCertificateAuthorityConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmpcaCertificateAuthority(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmpcaCertificateAuthority(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPermanentDeletionTimeInDays")]
        public virtual void ResetPermanentDeletionTimeInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRevocationConfiguration")]
        public virtual void ResetRevocationConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateAuthorityConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration[] CertificateAuthorityConfigurationInput
        {
            get => GetInstanceProperty<aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration[]>()!;
        }

        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateChain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateSigningRequest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateSigningRequest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotAfter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notBefore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotBefore
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Serial
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permanentDeletionTimeInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PermanentDeletionTimeInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "revocationConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityRevocationConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAcmpcaCertificateAuthorityRevocationConfiguration[]? RevocationConfigurationInput
        {
            get => GetInstanceProperty<aws.IAcmpcaCertificateAuthorityRevocationConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.AcmpcaCertificateAuthorityTimeouts\"}", isOptional: true)]
        public virtual aws.IAcmpcaCertificateAuthorityTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IAcmpcaCertificateAuthorityTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateAuthorityConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration[] CertificateAuthorityConfiguration
        {
            get => GetInstanceProperty<aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Enabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "permanentDeletionTimeInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PermanentDeletionTimeInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "revocationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityRevocationConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IAcmpcaCertificateAuthorityRevocationConfiguration[] RevocationConfiguration
        {
            get => GetInstanceProperty<aws.IAcmpcaCertificateAuthorityRevocationConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AcmpcaCertificateAuthorityTimeouts\"}")]
        public virtual aws.IAcmpcaCertificateAuthorityTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IAcmpcaCertificateAuthorityTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
