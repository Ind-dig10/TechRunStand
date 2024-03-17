
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Palmmedia.ReportGenerator.Core.Common;
using System.Xml.Linq;
using Newtonsoft.Json;

public class YAGPTManager : MonoBehaviour
{
    public string Result {  get; private set; }

    public async Task SearchAlenaAsync(string text)
    {
        Result = await TestYandAsync(text);
    }

    private async Task<string> TestYandAsync(string searchText)
    {
        using (var client = new HttpClient())
        {
            var prompt = new
            {
                modelUri = "gpt://тут нужен код директории/yandexgpt-lite",
                completionOptions = new
                {
                    stream = false,
                    temperature = 0.6,
                    maxTokens = "2000"
                },
                messages = new[]
                {
                    new
                    {
                        role = "system",
                        text = "Тебя зовут - Алена. Ты виртуальный помошник, который помогает туристам и всем желающим подсказать что угодно по городу"
                    },
                    new
                    {
                        role = "user",
                        text = searchText
                    }
                }
            };

            var url = "https://llm.api.cloud.yandex.net/foundationModels/v1/completion";
            var apiKey = "тут нужен ключ";

            var requestContent = new StringContent(JsonConvert.SerializeObject(prompt), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Api-Key " + apiKey);

            var response = await client.PostAsync(url, requestContent);
            if (!response.IsSuccessStatusCode)
            {
                Debug.LogError($"Error occurred: {response.ReasonPhrase}");
                return null;
            }

            var result = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<YAGptResponse>(result);
            if (responseObject != null && responseObject.result != null && responseObject.result.alternatives.Length > 0)
            {
                string responseResult = responseObject.result.alternatives[0].message.text;
                Debug.Log(responseResult);
                return responseResult;
            }
            else
            {
                Debug.LogWarning("No valid response received from the server.");
                return null;
            }
        }
    }
}
