﻿namespace BlogApi.Model
{
    public class Blog
    {
        public int Id { get; set; }
        public string author { get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
        public string content { get; set; } = string.Empty;

    }
}
