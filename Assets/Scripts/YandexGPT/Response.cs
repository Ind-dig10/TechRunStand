using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YAGptResponse
{
    public Result result { get; set; }
}

public class Result
{
    public Alternative[] alternatives { get; set; }
}

public class Alternative
{
    public Message message { get; set; }
}

public class Message
{
    public string text { get; set; }
}
