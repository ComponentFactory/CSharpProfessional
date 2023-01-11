# Solution
dotnet new sln -n CSharpProfessional

# .gitignore
dotnet new gitignore

# .editorConfig
copied from github dotnet/runtime/.editorconfig

# Add a new project, example
dotnet new console -o ./0003_record_internals
dotnet sln add ./0003_record_internals

# CodeLens
File -> Preferences -> Settings -> csharp.referencesCodeLens.enabled