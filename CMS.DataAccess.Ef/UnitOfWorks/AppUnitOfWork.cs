﻿using System;
using Elk.Core;
using System.Threading;
using System.Threading.Tasks;
using Elk.EntityFrameworkCore;
using CMS.Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CMS.DataAccess.Ef
{
    public sealed class AppUnitOfWork : IElkUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private readonly IServiceProvider _serviceProvider;

        public AppUnitOfWork(IServiceProvider serviceProvider, AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _serviceProvider = serviceProvider;
        }


        #region Base
        public IUserRepo UserRepo => _serviceProvider.GetService<IUserRepo>();
        public IGenericRepo<Address> AddressRepo => _serviceProvider.GetService<IGenericRepo<Address>>();
        //public INotificationRepo NotificationRepo => _serviceProvider.GetService<INotificationRepo>();
        #endregion

        
        public ChangeTracker ChangeTracker { get => _appDbContext.ChangeTracker; }
        public DatabaseFacade Database { get => _appDbContext.Database; }

        public SaveChangeResult ElkSaveChanges()
            => _appDbContext.ElkSaveChanges();

        public Task<SaveChangeResult> ElkSaveChangesAsync(CancellationToken cancellationToken = default)
            => _appDbContext.ElkSaveChangesAsync(cancellationToken);

        public SaveChangeResult ElkSaveChangesWithValidation()
            => _appDbContext.ElkSaveChangesWithValidation();

        public Task<SaveChangeResult> ElkSaveChangesWithValidationAsync(CancellationToken cancellationToken = default)
            => _appDbContext.ElkSaveChangesWithValidationAsync(cancellationToken);

        public int SaveChanges()
            => _appDbContext.SaveChanges();

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
            => _appDbContext.SaveChangesAsync(cancellationToken);

        public Task<int> SaveChangesAsync(bool AcceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
            => _appDbContext.SaveChangesAsync(AcceptAllChangesOnSuccess, cancellationToken);

        public void Dispose() => _appDbContext.Dispose();
    }
}