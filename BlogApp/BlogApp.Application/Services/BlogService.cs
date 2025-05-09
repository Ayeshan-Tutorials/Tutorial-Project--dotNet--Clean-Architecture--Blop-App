﻿using BlogApp.Domain.Entities;
using BlogApp.Domain.Interface;

namespace BlogApp.Application.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public BlogService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<Blog> CreateAsync(Blog blog)
        {
            return await _blogRepository.CreateAsync(blog);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _blogRepository.DeleteAsync(id);
        }

        public async Task<List<Blog>> GetAllAsync()
        {
            return await _blogRepository.GetAllAsync();
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _blogRepository.GetByIdAsync(id);
        }

        public async Task<int> UpdateAsync(int id, Blog blog)
        {
            return await _blogRepository.UpdateAsync(id, blog);
        }
    }
}
