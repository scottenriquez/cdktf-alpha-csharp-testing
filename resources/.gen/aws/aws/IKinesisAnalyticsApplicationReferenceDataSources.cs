using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSources), fullyQualifiedName: "aws.KinesisAnalyticsApplicationReferenceDataSources")]
    public interface IKinesisAnalyticsApplicationReferenceDataSources
    {
        /// <summary>s3 block.</summary>
        [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesS3\"},\"kind\":\"array\"}}")]
        aws.IKinesisAnalyticsApplicationReferenceDataSourcesS3[] S3
        {
            get;
        }

        /// <summary>schema block.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchema\"},\"kind\":\"array\"}}")]
        aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchema[] Schema
        {
            get;
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSources), fullyQualifiedName: "aws.KinesisAnalyticsApplicationReferenceDataSources")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationReferenceDataSources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3 block.</summary>
            [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesS3\"},\"kind\":\"array\"}}")]
            public aws.IKinesisAnalyticsApplicationReferenceDataSourcesS3[] S3
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationReferenceDataSourcesS3[]>()!;
            }

            /// <summary>schema block.</summary>
            [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchema\"},\"kind\":\"array\"}}")]
            public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchema[] Schema
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchema[]>()!;
            }

            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
