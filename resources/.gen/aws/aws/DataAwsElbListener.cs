using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsElbListener), fullyQualifiedName: "aws.DataAwsElbListener", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsElbListener : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsElbListener(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElbListener(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElbListener(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "instancePort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstancePort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lbPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LbPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lbProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LbProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslCertificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslCertificateId
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
