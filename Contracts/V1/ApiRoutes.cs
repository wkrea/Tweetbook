﻿namespace Tweetbook.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Posts
        {
            public const string GetAll = Base + "/posts";
            //public static readonly string GetById = $"{Base}/posts/{PostId}";
            //public static readonly string Create  = $"{Base}/posts";
        }
    }
}
