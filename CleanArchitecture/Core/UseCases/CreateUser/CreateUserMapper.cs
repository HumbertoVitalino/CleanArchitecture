﻿using AutoMapper;
using Core.Entities;

namespace Core.UseCases.CreateUser;

public sealed class CreateUserMapper : Profile
{
	public CreateUserMapper()
	{
		CreateMap<CreateUserRequest, User>();
		CreateMap<User, CreateUserResponse>();			
	}
}
