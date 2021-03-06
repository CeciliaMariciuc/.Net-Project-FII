﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autentification.Model;
using Authentication.Microservice.Model.Requests;
using MongoDB.Driver;

namespace Autentification.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(IUsersDatabaseSettings settings)
        {
            _context = new DataContext(settings);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            try 
            {
                return await _context.Users.Find(UserRepository => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> GetById(string id)
        {
            try
            {
                return await _context.Users
                    .Find(user => user.Id == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> CheckUser(string email, string password)
        {
            try
            {
                return await _context.Users
                    .Find(user => user.Email == email && user.Password == password)
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> GetByEmail(string email)
        {
            try
            {
                return await _context.Users
                    .Find(user => user.Email == email)
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> IsEmailUsed(string email)
        {
            try
            {
              User user =  await _context.Users
                    .Find(user => user.Email == email)
                    .FirstOrDefaultAsync();

                if (user != null)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateUser(string id,User user)
        {
            try 
            {
                await _context.Users.ReplaceOneAsync(user => user.Id == id, user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteUser(string id)
        {
            try 
            {
                await _context.Users.DeleteOneAsync(movie => movie.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddUser(User user)
        {
            try
            {
                await _context.Users.InsertOneAsync(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task ChangePassword(ChangePasswordRequest request)
        {
            try
            {
                User user = await _context.Users
                    .Find(user => user.Id == request.UserId)
                    .FirstOrDefaultAsync();
                user.Password = request.NewPassword;
                await UpdateUser(request.UserId, user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
