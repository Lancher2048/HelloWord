using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcDemo.Service.DataAccess;
using GrpcDemo.Service.Models;
using Microsoft.Extensions.Logging;

namespace GrpcDemo.Service
{
    public class GreeterService : Greeter.GreeterBase
    {
        private DataContext _db;
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger, DataContext db)
        {
            _logger = logger;
            _db = db;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }

        //public override Task<User> SelectAll(User request, ServerCallContext context)
        //{
        //    User responseData = new User();
        //    var query = from user in _db.Users
        //        select new User()
        //        {
        //            Id = user.Id,
        //            Password = user.Password,
        //            UserName = user.UserName
        //        };
            
        //}
    }
}
