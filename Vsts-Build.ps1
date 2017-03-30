function Build-Project( [string]$projectPath)
{
	dotnet restore $projectPath
	dotnet clean $projectPath
	dotnet build $projectPath -c Release
	dotnet pack $projectPath -c Release
}

Build-Project( "src/Microsoft.Azure.Mobile.Client" )
Build-Project( "src/Microsoft.Azure.Mobile.Client.SQLiteStore" )