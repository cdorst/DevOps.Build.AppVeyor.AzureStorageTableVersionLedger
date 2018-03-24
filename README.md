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
WindowsAzure.Storage | [![NuGet package status](https://img.shields.io/nuget/v/WindowsAzure.Storage.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/WindowsAzure.Storage)

## Dependents

The project below uses this repository as a direct dependency.

Name | Status
---- | ------
[DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder](https://github.com/CDorst./DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst./devops-build-appveyor-azurestoragetableversionledg.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst./devops-build-appveyor-azurestoragetableversionledg) [![NuGet package status](https://img.shields.io/nuget/v/CDorst..DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst..DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AzureStorageTableVersionLedger](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AzureStorageTableVersionLedger)

## Version

1.0.0

## Metaproject

DevOps.Build.AppVeyor.AzureStorageTableVersionLedger is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

