$rootPath = (Get-Item -Path "./" -Verbose).FullName

Set-Location $rootPath

Get-ChildItem src/**/NativeAsset.txt -recurse | ForEach-Object -Process {
	if ($_ -is [System.IO.FileInfo]) {
        $uri = Get-Content $_.FullName -TotalCount 1
        $name= (Get-Content $_.FullName -TotalCount 2)[-1]
        Write-Host("Downloading " + $name + " from " + $uri)
        $fullName = (Join-Path $_.Directory $name)
		Invoke-WebRequest -Uri $uri -OutFile $fullName
	}
}