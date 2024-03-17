using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat : MonoBehaviour
{
    [Header("Chat")]
    //[SerializeField] private Text ChatHistoryText;
    [SerializeField] private Text UserText;
    [SerializeField] private Text AvatarText;
    [SerializeField] private InputField MessageInput;
    [SerializeField] private Button SendButton;

    public async void SendText()
    {
        //ChatHistoryText.text += MessageInput.text + "\n";
        UserText.text = MessageInput.text;
        YAGPTManager yagptManager = new YAGPTManager();
        await yagptManager.SearchAlenaAsync(MessageInput.text);
        string result = yagptManager.Result;
        AvatarText.text = result;
        MessageInput.text = string.Empty;
        //ChatHistoryText.text += result + "\n";
    }
}
