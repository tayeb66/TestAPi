using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    public Dictionary<string, List<string>> fruitMap = new Dictionary<string, List<string>>()
    {
        { "apple", new List<string>(){"apple","bananas","bananas","bananas","bananas" }},
        { "apple1", new List<string>(){"apple","bananas","bananas","bananas","bananas" }},
        { "apple2", new List<string>(){"apple","bananas","bananas","bananas","bananas" }},
        { "apple3", new List<string>(){"apple","bananas","bananas","bananas","bananas" }},
        { "apple4", new List<string>(){"apple","bananas","bananas","bananas","bananas" }},
    };

    [HttpGet("number")]
    public Dictionary<int, int> getNumbers()
    {
        Dictionary<int,int> numberMap = new Dictionary<int,int>();
        numberMap[1] = 1;
        numberMap[1] = 2;
        numberMap[1] = 3;
        Console.WriteLine(numberMap[1]);
        return numberMap;
    }

    [HttpGet("fruit")]
    public Dictionary<string,List<string>> GetFruits()
    {
        return fruitMap;
    }

    public List<dynamic> FruitList = new List<dynamic>()
    {
        "apple",
        12,
        "bananas",
        456,
        34.56,
        "bananas",
        new Dictionary<String,dynamic>
        {
            {"name","bananas"},
            {"color","yellow"},
            {"size","medium"},
        }
    };

    [HttpGet("fruitList")]
    public List<dynamic> GetFruitList()
    {
        return FruitList;
    }

    [HttpGet("Fruits/{id}")]
    public dynamic getFruitById(int id)
    {
        return FruitList.ElementAt(id);
    }

}