using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAlbListenerDefaultAction), fullyQualifiedName: "aws.DataAwsAlbListenerDefaultAction", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsAlbListenerDefaultAction : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsAlbListenerDefaultAction(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAlbListenerDefaultAction(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAlbListenerDefaultAction(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AuthenticateCognito
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AuthenticateOidc
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "fixedResponse", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object FixedResponse
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Order
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Redirect
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetGroupArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
