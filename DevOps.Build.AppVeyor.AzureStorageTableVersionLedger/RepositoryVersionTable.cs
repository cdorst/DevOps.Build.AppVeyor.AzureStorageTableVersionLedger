// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

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
