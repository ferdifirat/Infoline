﻿using Infoline.Api.Business.Abstract;
using Infoline.Api.DataAccess.Abstract;
using Infoline.Api.Dto;
using Infoline.Api.Entities;
using Infoline.Api.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Infoline.Api.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;


        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public bool AddUsers(List<UserDto> userInfoViewModel)
        {
            var result = true;
            foreach (var item in userInfoViewModel)
            {
                var user = new User()
                {
                    Age = item.age,
                    Cell = item.cell,
                    City = item.city,
                    Email = item.email,
                    FirstName = item.first,
                    Gender = item.gender,
                    LastName = item.last,
                    PostCode = item.postcode,
                    UserName = item.username

                };
                _userDal.Add(user);
                result = _userDal.SaveChanges();
                if (!result)
                {
                    break;
                }


            }
            return result;
        }

        public bool DeleteUser(int id)
        {
            var user = _userDal.Get(p => p.Id == id);

            if (user == null)
            {
                return false;
            }

            _userDal.Delete(user);
            return _userDal.SaveChanges();

        }

        public UserInfoViewModel GetRandomUsers()
        {
            var response = new UserInfoViewModel();
            using (WebClient webClient = new WebClient())
            {
                var json = webClient.DownloadString("https://randomuser.me/api/?page=1&results=10&nat=Tr");
                var data = JsonConvert.DeserializeObject<RootObject>(json);
                //return data;
                response.Users = new List<UserDto>();
                foreach (var item in data.Results)
                {
                    var user = new UserDto()
                    {
                        gender = item.Gender,
                        cell = item.Cell,
                        email = item.Email,
                        username = item.Login.UserName,
                        first = item.Name.First,
                        last = item.Name.Last,
                        age = item.Dob.Age,
                        city = item.Location.City,
                        postcode = item.Location.Postcode,
                    };

                    response.Users.Add(user);
                }
            }

            return response;
        }

        public UserInfoViewModel GetUsers()
        {
            var users = new UserInfoViewModel();
            users.Users = new List<UserDto>();

            var repos = _userDal.GetList();

            foreach (var item in repos)
            {
                var user = new UserDto();
                user = user.Map(item);
                users.Users.Add(user);
            }


            return users;
        }

        public List<UserSummaryDto> GetUsersSummary()
        {
            var result = new List<UserSummaryDto>();

            var users = _userDal.GetList();

            foreach (var item in users)
            {
                var summary = new UserSummaryDto()
                {
                    FullName = item.FirstName + " " + item.LastName,
                    Id = item.Id
                };

                result.Add(summary);
            }
            return result;
        }
    }
}
