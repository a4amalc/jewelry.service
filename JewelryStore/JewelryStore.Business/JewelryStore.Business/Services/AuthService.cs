using AutoMapper;
using JewelryStore.Data.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace JewelryStore.Business.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AuthService> _logger;
        public AuthService(IAuthRepository authRepository,
                                   IMapper mapper,
                                   ILogger<AuthService> logger)
        {
            _authRepository = authRepository ?? throw new ArgumentNullException(nameof(authRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public UserDto Login(LoginDto loginDto)
        {
            var user = _authRepository.Login(loginDto.UserName, loginDto.Password);
            return _mapper.Map<UserDto>(user);

        }
    }
}
