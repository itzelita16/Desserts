using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xamarin_Azure_CosmosDB.Service
{
    public interface ICosmosDBService<T>
    {
        Task CreateDatabase(string databaseName);

        Task CreateDocumentCollection(string databaseName, string collectionName);

        Task<List<T>> GetItemsAsync<T>();

        Task SaveItemAsync<T>(T item, string id, bool isNewItem = false);

        Task DeleteItemAsync(string id);
    }
}
