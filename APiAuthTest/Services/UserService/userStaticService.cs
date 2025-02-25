﻿using System.Security.Claims;
using APiAuthTest.Model.UserModel;

namespace APiAuthTest.Services.UserService
{
    public class userStaticService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private static List<User> _user = new List<User>();
        public userStaticService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public User FindOneUser(string username)
        {
            return _user.FirstOrDefault(u => u.Username == username);
        }

        public bool InsertUser(User user)
        {
            _user.Add(user);
            return true;
        }

        public string GetMyName()
        {
            var result = string.Empty;
            if (_httpContextAccessor.HttpContext != null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;
        }

        public IEnumerable<Permissions> GetPermissions(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Personne> GetPersonnes(int? id = null)
        {
            throw new NotImplementedException();
        }

        public Personne PostPersonnes(Personne p)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Personne> GetPersonnes()
        {
            throw new NotImplementedException();
        }

        public Personne GetPersonne(int id)
        {
            throw new NotImplementedException();
        }

        public void PutPersonnes(PersonneDTO p, int id)
        {
            throw new NotImplementedException();
        }

        public Personne DelPersonnes(int id)
        {
            throw new NotImplementedException();
        }
    }
}
