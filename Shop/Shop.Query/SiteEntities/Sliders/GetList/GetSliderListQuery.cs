using Common.Query;
using Shop.Query.SiteEntities.DTOs;

namespace Shop.Query.SiteEntities.Sliders.GetList;

public record GetSliderListQuery : IQuery<List<SliderDto>>;