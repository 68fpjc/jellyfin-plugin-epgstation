#! /bin/sh

docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli generate \
    -g csharp \
    -o /local/out/ \
    -i /local/spec/openapi-mod.json \
    -p targetFramework=net8.0 -p packageName=X68fpjc.Jellyfin.EPGStation.OpenAPI
