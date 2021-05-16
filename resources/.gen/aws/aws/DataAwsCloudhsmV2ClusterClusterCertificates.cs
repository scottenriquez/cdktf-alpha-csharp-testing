using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsCloudhsmV2ClusterClusterCertificates), fullyQualifiedName: "aws.DataAwsCloudhsmV2ClusterClusterCertificates", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsCloudhsmV2ClusterClusterCertificates : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsCloudhsmV2ClusterClusterCertificates(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudhsmV2ClusterClusterCertificates(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudhsmV2ClusterClusterCertificates(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "awsHardwareCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsHardwareCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterCsr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterCsr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hsmCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HsmCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "manufacturerHardwareCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManufacturerHardwareCertificate
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
