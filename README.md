# DevOps.Build.AppVeyor.AzureStorageTableVersionLedger

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-azurestoragetableversionledg.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-azurestoragetableversionledg)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AzureStorageTableVersionLedger)

## Description

Azure Table Storage entity representing a current repository version

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Azure.Storage.Metapackage](https://github.com/CDorst/Azure.Storage.Metapackage) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-metapackage.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/azure-storage-metapackage) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Metapackage.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Azure.Storage.Metapackage)

## Dependents

The projects below use this repository as a direct dependency.

Name | Status
---- | ------
[DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder](https://github.com/CDorst./DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst./devops-build-appveyor-azurestoragetableversionledg.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst./devops-build-appveyor-azurestoragetableversionledg) [![NuGet package status](https://img.shields.io/nuget/v/CDorst..DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst..DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder)
[DevOps.Build.AppVeyor.GetRepositoryVersionRecord](https://github.com/CDorst./DevOps.Build.AppVeyor.GetRepositoryVersionRecord) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst./devops-build-appveyor-getrepositoryversionrecord.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst./devops-build-appveyor-getrepositoryversionrecord) [![NuGet package status](https://img.shields.io/nuget/v/CDorst..DevOps.Build.AppVeyor.GetRepositoryVersionRecord.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst..DevOps.Build.AppVeyor.GetRepositoryVersionRecord)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AzureStorageTableVersionLedger](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AzureStorageTableVersionLedger)

## Version

1.0.9

## Metaproject

DevOps.Build.AppVeyor.AzureStorageTableVersionLedger is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

