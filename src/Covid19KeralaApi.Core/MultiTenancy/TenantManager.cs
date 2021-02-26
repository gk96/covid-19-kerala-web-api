using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Covid19KeralaApi.Authorization.Users;
using Covid19KeralaApi.Editions;

namespace Covid19KeralaApi.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
