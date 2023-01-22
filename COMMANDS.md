# Solution
dotnet new sln -n CSharpProfessional

# .gitignore
dotnet new gitignore

# .editorConfig
copied from github dotnet/runtime/.editorconfig

# Add a new project, example
dotnet new console -o ./0004_syntactic_sugar
dotnet sln add ./0004_syntactic_sugar
cd ./0004_syntactic_sugar

# CodeLens
File -> Preferences -> Settings -> csharp.referencesCodeLens.enabled