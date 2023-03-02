$apiKey = $args[0]

$rootPath = (Get-Item -Path "./" -Verbose).FullName

Set-Location $rootPath

Get-ChildItem src/**/bin/Release/*.nupkg -recurse | ForEach-Object -Process {
	if ($_ -is [System.IO.FileInfo]) {
		dotnet nuget push $_.Name -s https://api.nuget.org/v3/index.json --api-key "$apiKey" --skip-duplicate
	}
}

Set-Location $rootPath
