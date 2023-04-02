﻿using System;
namespace EF007.ConfigurationUsingFluentAPI.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int TweetId { get; set; }
        public int UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}



