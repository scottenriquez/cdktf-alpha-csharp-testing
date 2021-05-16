using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AcmCertificateDomainValidationOptions), fullyQualifiedName: "aws.AcmCertificateDomainValidationOptions", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AcmCertificateDomainValidationOptions : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public AcmCertificateDomainValidationOptions(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmCertificateDomainValidationOptions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmCertificateDomainValidationOptions(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceRecordName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceRecordName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceRecordType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceRecordType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceRecordValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceRecordValue
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
