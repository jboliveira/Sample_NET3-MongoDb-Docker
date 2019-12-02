﻿namespace SampleApi.Infrastructure
{
	public class MongoDbSettings : IMongoDbSettings
	{
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
		public string SamplesCollectionName { get; set; }
	}
}
