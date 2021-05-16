using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchDashboard), fullyQualifiedName: "aws.CloudwatchDashboard", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CloudwatchDashboardConfig\"}}]")]
    public class CloudwatchDashboard : HashiCorp.Cdktf.TerraformResource
    {
        public CloudwatchDashboard(Constructs.Construct scope, string id, aws.ICloudwatchDashboardConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchDashboard(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchDashboard(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "dashboardArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DashboardArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dashboardBodyInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DashboardBodyInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dashboardNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DashboardNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dashboardBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DashboardBody
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dashboardName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DashboardName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
