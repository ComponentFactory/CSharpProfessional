# Solution
dotnet new sln -n CSharpProfessional

# .gitignore
dotnet new gitignore

# .editorConfig
copied from github dotnet/runtime/.editorconfig

# Add a new project, example
dotnet new console -o ./0005_patterns
dotnet sln add ./0005_patterns
cd ./0005_patterns

# CodeLens
File -> Preferences -> Settings -> csharp.referencesCodeLens.enabled