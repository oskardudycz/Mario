#!/usr/bin/env bash
set -euo pipefail

version="$(dotnet --version)"
if [[ $version = 6.* ]]; then
  target_framework="net6.0"
else
  echo "BUILD FAILURE: .NET 6 SDK required to run build"
  exit 1
fi

dotnet run --project src/Mario.Build/Mario.Build.csproj -f $target_framework -c Release -- "$@"
