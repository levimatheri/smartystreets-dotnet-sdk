﻿using Microsoft.Extensions.Options;

namespace Smarty.Net.Core.Shared;
internal class ConfigureClientOptions<TClient, TOptions> : IConfigureNamedOptions<TOptions> where TOptions : class
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ClientRegistration<TClient> _registration;
    private readonly Action<TOptions, IServiceProvider> _configureOptions;

    public ConfigureClientOptions(IServiceProvider serviceProvider, ClientRegistration<TClient> registration, Action<TOptions, IServiceProvider> configureOptions)
    {
        _serviceProvider = serviceProvider;
        _registration = registration;
        _configureOptions = configureOptions;
    }

    public void Configure(TOptions options)
    {
    }

    public void Configure(string? name, TOptions options)
    {
        if (string.Equals(name, _registration.Name))
        {
            _configureOptions(options, _serviceProvider);
        }
    }
}
