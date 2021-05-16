using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEfsAccessPointPosixUser), fullyQualifiedName: "aws.DataAwsEfsAccessPointPosixUser", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsEfsAccessPointPosixUser : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsEfsAccessPointPosixUser(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEfsAccessPointPosixUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEfsAccessPointPosixUser(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Gid
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "secondaryGids", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object SecondaryGids
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Uid
        {
            get => GetInstanceProperty<double>()!;
        }
    }
}
