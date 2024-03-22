using Shared.ContentFeed;
using System;

namespace Server.Features.ContentFeed
{
    public class CrawledContent
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public ContentSource Source { get; set; }
        public string Startup { get; set; }
        public NewsType Type { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Ignored { get; set; }
    }

    public enum ContentSource
    {
        MailNewsletter,
        WhattsApp
    }
}
