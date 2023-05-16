using Common.Domain.Repository;

namespace Shop.Domain.SiteEntities.Repositories;

public interface IBannerRepository : IBaseRepository<Banner>
{
    void Delete(Banner banner);
}