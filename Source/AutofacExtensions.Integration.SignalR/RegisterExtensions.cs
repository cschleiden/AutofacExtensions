﻿using System;
using Autofac;
using Microsoft.AspNet.SignalR.Hubs;

namespace AutofacExtensions.Integration.SignalR
{
	public static class RegisterExtensions
	{
		public static void RegisterLifetimeHubManager(this ContainerBuilder builder)
		{
			if (builder == null) {
				throw new ArgumentNullException("builder");
			}
			builder.RegisterType<LifetimeHubManager>().SingleInstance();
			builder.RegisterType<AutofacHubActivator>().As<IHubActivator>().SingleInstance();
		}
	}
}
