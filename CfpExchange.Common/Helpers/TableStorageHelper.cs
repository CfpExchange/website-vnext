using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Azure.Cosmos.Table;

namespace CfpExchange.Common.Helpers
{
	public static class TableStorageHelper
	{
		public static async Task<IEnumerable<T>> GetEntitiesFromTableAsync<T>(CloudTable table) where T : ITableEntity, new()
		{
			TableQuerySegment<T> querySegment = null;
			var entities = new List<T>();
			var query = new TableQuery<T>();

			do
			{
				querySegment = await table.ExecuteQuerySegmentedAsync(query, querySegment?.ContinuationToken);
				entities.AddRange(querySegment.Results);
			} while (querySegment.ContinuationToken != null);

			return entities;
		}

		public static async Task<IEnumerable<T>> GetEntitiesFromTableByPartitionKeyAsync<T>(CloudTable table, string partitionKey) where T : ITableEntity, new()
		{
			TableQuerySegment<T> querySegment = null;
			var entities = new List<T>();
			var query = new TableQuery<T>().Where(TableQuery.GenerateFilterCondition(nameof(ITableEntity.PartitionKey), QueryComparisons.Equal, partitionKey));

			do
			{
				querySegment = await table.ExecuteQuerySegmentedAsync(query, querySegment?.ContinuationToken);
				entities.AddRange(querySegment.Results);
			} while (querySegment.ContinuationToken != null);

			return entities;
		}
	}
}
