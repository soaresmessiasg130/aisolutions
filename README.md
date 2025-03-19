# AISolutions

## GeneratedImageAI

Use your OpenAI API Key to generate images.

### Requirements

.NET 9 installed and your OpenAIKey.

### Before run

You need to setup your `OpenAIKey` and `ModelName`, using the `dotnet user-secrets` command:

#### Setup `OpenAIKey`

Run `dotnet user-secrets set OpenAIKey <your-key>` inside `GeneratedImageAI` folder.

#### Setup `ModelName`

Run `dotnet user-secrets set ModelName <model-name>` inside `GeneratedImageAI` folder.

I recomend `dall-e-3` for `ModelName`.

### Instructions to run

Go to `Program.cs` file, and modify the `prompt` variable.

On the Console run `dotnet run` inside `GeneratedImageAI` folder.

The output will show the image file location.

Enjoy!
