using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.MskClusterClientAuthentication")]
    public class MskClusterClientAuthentication : aws.IMskClusterClientAuthentication
    {
        /// <summary>tls block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tls", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterClientAuthenticationTls\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterClientAuthenticationTls[]? Tls
        {
            get;
            set;
        }
    }
}
