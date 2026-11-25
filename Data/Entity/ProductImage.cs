using System;

namespace p48_lessons_asp.Data.Entity;

public class ProductImage
{
    public Guid Id {get;set;} = Guid.NewGuid();
    public Guid ProductId{get;set;}
    public string Url{get;set;} = string.Empty;
    public DateTime CreatedAt{get;set;} = DateTime.Now;
    
    public Product? Product{get;set;}
}
