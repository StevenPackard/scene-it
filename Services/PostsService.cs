using System;
using System.Collections.Generic;
using System.Data;
using scene_it.Models;
using scene_it.Repositories;

namespace scene_it.Services
{
  public class PostsService
  {
    private readonly PostsRepository _repo;
    public PostsService(PostsRepository repo)
    {
      _repo = repo;
    }
  }
}