﻿using OPC5_BlogApp.Data.Models;

namespace Services.Posts
{
    public interface IPostService
    {
        void AddPost(Post post);
    }
}