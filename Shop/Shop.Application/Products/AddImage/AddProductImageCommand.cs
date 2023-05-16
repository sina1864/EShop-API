using Common.Application;
using Microsoft.AspNetCore.Http;

namespace Shop.Application.Products.AddImage;

public class AddProductImageCommand : IBaseCommand
{
    public IFormFile ImageFile { get; set; }
    public long ProductId { get; set; }
    public int Sequence { get; set; }
}