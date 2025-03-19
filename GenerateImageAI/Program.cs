using Microsoft.Extensions.Configuration;
using OpenAI.Images;

var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();

string openAIKey = config["OpenAIKey"]!;
string modelName = config["ModelName"]!;

ImageClient imageClient = new(modelName, openAIKey);

// MODIFY THIS BY YOUR PROMPT
string prompt = """Generate a beautiful image of a otter!""";

ImageGenerationOptions imageGenerationOptions = new()
{
  Size = GeneratedImageSize.W1024xH1024,
};

GeneratedImage generatedImage = await imageClient.GenerateImageAsync(prompt, imageGenerationOptions);

Console.WriteLine($"The image are located at {generatedImage.ImageUri}");
