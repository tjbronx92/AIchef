using System;
using AIchef.Shared;

namespace AIchef.Server.Services
{
	public interface IOpenAIAPI
	{
		Task<List<Idea>> CreateRecipeIdea(string mealtime, List<string> ingredients);
		Task<Recipe>
	}
}

