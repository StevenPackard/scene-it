using System;
using System.Collections.Generic;
using System.Data;
using scene_it.Models;
using Dapper;

namespace scene_it.Repositories
{
  public class PostsRepository
  {
    private readonly IDbConnection _db;

    public PostsRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}