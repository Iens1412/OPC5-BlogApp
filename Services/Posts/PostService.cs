﻿using OPC5_BlogApp.Data;
using OPC5_BlogApp.Data.Models;

namespace Services.Posts
{
    public class PostService(ApplicationDbContext _context) : IPostService
    {
        private readonly ApplicationDbContext context = _context;

        public void AddPost(Post post)
        {
            context.Posts.Add(post);
            context.SaveChanges();
        }

        public List<Post> GetPosts()
        {
            List<Post> allPosts = context.Posts.ToList();

            return allPosts;
        }

        public List<Comment> GetPostComments(int postId)
        {
            Post post = context.Posts.Single(p => p.PostId == postId);

            if (post == null) return new List<Comment>();

            List<Comment> postComments = post.PostComments.ToList();

            return postComments;
        }
    }
}
