using System;
using AIchef.Shared;

namespace AIchef.Server.Services
{
	public interface IOpenAIAPI
	{
		Task<List<Idea>> CreateRecipeIdeas(string mealtime, List<string> ingredients);
	}
}

