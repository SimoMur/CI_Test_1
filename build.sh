set -e
rm -fr ./out
dotnet restore ./TestMockApplication
dotnet publish -c Release -o ./out ./TestMockApplication