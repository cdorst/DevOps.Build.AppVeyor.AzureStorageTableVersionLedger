using Microsoft.WindowsAzure.Storage.Table;

namespace DevOps.Build.AppVeyor.AzureStorageTableVersionLedger
{
    /// <summary>Azure Table Storage entity representing a current repository version</summary>
    public class RepositoryVersionTable : TableEntity
    {
        public RepositoryVersionTable()
        {
        }

        public RepositoryVersionTable(string accountName, string repositoryName, string version)
        {
PartitionKey = accountName;
RowKey = repositoryName;
Version = version;;
        }

        /// <summary>Current version of repository</summary>
public string Version { get;
set;
};
    }
}
