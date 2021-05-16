using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsOrganizationsOrganizationalUnits), fullyQualifiedName: "aws.DataAwsOrganizationsOrganizationalUnits", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsOrganizationsOrganizationalUnitsConfig\"}}]")]
    public class DataAwsOrganizationsOrganizationalUnits : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsOrganizationsOrganizationalUnits(Constructs.Construct scope, string id, aws.IDataAwsOrganizationsOrganizationalUnitsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsOrganizationalUnits(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsOrganizationalUnits(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "children", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsOrganizationsOrganizationalUnitsChildren\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsOrganizationsOrganizationalUnitsChildren Children(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsOrganizationsOrganizationalUnitsChildren>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
