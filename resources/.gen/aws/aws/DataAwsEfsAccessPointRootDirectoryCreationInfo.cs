using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEfsAccessPointRootDirectoryCreationInfo), fullyQualifiedName: "aws.DataAwsEfsAccessPointRootDirectoryCreationInfo", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsEfsAccessPointRootDirectoryCreationInfo : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsEfsAccessPointRootDirectoryCreationInfo(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEfsAccessPointRootDirectoryCreationInfo(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEfsAccessPointRootDirectoryCreationInfo(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OwnerGid
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OwnerUid
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Permissions
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
