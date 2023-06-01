
using Logitop.Utils;
using System.Text.Json;

namespace Logitop.Services
{
    public class WeatherAPI
    {
        public static async Task<Dictionary<string, dynamic>?> CurrentWeatherData(string city, string? unit)
        {
            Dictionary<string, dynamic> weatherData = new Dictionary<string, dynamic>();

            string degreeUnit = "metric";

            if (unit != null)
            {
                switch (unit)
                {
                    case "Kelvin":
                        degreeUnit = string.Empty;
                        break;
                    case "Fahrenheit":
                        degreeUnit = "imperial";
                        break;
                    default:
                        degreeUnit = "metric";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(degreeUnit))
            {
                degreeUnit = "&units=" + degreeUnit;
            }

            string uriString = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={Global.OpenWheatherMapApiKey}{degreeUnit}";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(uriString);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            string responseBody = await response.Content.ReadAsStringAsync();

            JsonDocument jsonDocument = JsonDocument.Parse(responseBody);

            weatherData.Clear();
            foreach (JsonProperty property in jsonDocument.RootElement.EnumerateObject())
            {
                weatherData.Add(property.Name, GetJsonValue(property.Value));
            }

            return weatherData;
        }

        private static object GetJsonValue(JsonElement element)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    Dictionary<string, object> obj = new Dictionary<string, object>();
                    foreach (JsonProperty property in element.EnumerateObject())
                    {
                        obj.Add(property.Name, GetJsonValue(property.Value));
                    }
                    return obj;

                case JsonValueKind.Array:
                    List<object> array = new List<object>();
                    foreach (JsonElement arrayElement in element.EnumerateArray())
                    {
                        array.Add(GetJsonValue(arrayElement));
                    }
                    return array;

                case JsonValueKind.String:
                    return element.GetString()!;

                case JsonValueKind.Number:
                    return element.GetDouble()!;

                case JsonValueKind.True:
                    return true;

                case JsonValueKind.False:
                    return false;

                default:
                    throw new NotSupportedException("Unsupported JSON value kind " + element.ValueKind);
            }
        }
    }
}
