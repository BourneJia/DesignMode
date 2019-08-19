using System;

public class HelpAttribute: Attribute
{
    public HelpAttribute(string url) 
    {
        URL = url;
    }

    public string URL { get;set;}

    public string Topic { get;set;}
}