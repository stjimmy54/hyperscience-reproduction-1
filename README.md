# hyperscience-reproduction-1

For run you need to update appsettings.json

1. Create API user and set client_id and client_secret

Also you can update program.cs

Replace ```var pathToFile = "path_to_file_for_upload";``` with real path to file.

# hyperscience-reproduction-2
1. Open hyperscience-reproduction-2/Solution2.sln
2. Try add com.hyperscience.saas 1.0.2 nuget package to WebApi project
```
NU1107: Version conflict detected for Microsoft.Extensions.Configuration. Install/reference Microsoft.Extensions.Configuration 5.0.0 directly to project WebApi to resolve this issue. 
 WebApi -> com.hyperscience.saas 1.0.2 -> Microsoft.Extensions.Configuration.Json 5.0.0 -> Microsoft.Extensions.Configuration (>= 5.0.0) 
 WebApi -> Microsoft.AspNetCore.App 2.2.0 -> Microsoft.Extensions.Configuration (>= 2.2.0 && < 2.3.0).
```
