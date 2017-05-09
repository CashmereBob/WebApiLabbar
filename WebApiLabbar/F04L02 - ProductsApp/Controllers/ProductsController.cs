using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using F04L02___ProductsApp.Models;
using Newtonsoft.Json.Linq;

namespace F04L02___ProductsApp.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {

        // GET: api/Products
        [Route("GetAllProducts")]
        public IHttpActionResult GetAllProducts()
        {
            using (var ctx = new ProductEntities())
            {
                return Ok(ctx.Products.Include("Category").ToList());
            }
  
        }

        [Route("GetAllCategorys")]
        public IHttpActionResult GetAllCategorys()
        {
            using (var ctx = new ProductEntities())
            {
                var result = ctx.Categorys.ToList();
                return Ok(result);
            }

        }

        [Route("add/{name}/{category}/{price}")]
        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult Add(string name, int category, int price)
        {
            using (var ctx = new ProductEntities())
            {
                ctx.Products.Add(new Product {Name = name, CategoryId = category, Price = price });
                ctx.SaveChanges();

                return Ok(ctx.Products.Include("Category").ToList());
            }
        }

        [Route("addCategory")]
        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult AddCategory(Category cat)
        {
            using (var ctx = new ProductEntities())
            {
                ctx.Categorys.Add(cat);
                ctx.SaveChanges();

                var result = ctx.Categorys.ToList();
                return Ok(result);

            }
        }

        [Route("getproduct/{id}")]
        public IHttpActionResult GetProduct(int id)
        {

            using (var ctx = new ProductEntities())
            {
                var product = ctx.Products.Include("Category").FirstOrDefault((x) => x.Id == id);

                if (product != null)
                {
                    return Ok(product);
                }
                else
                {
                    return NotFound();
                }

            }
        }

        [Route("removeproduct/{id}")]
        [System.Web.Http.AcceptVerbs("GET", "POST", "DELETE")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult RemoveProduct(int id)
        {

            using (var ctx = new ProductEntities())
            {
                var product = ctx.Products.FirstOrDefault((x) => x.Id == id);

                ctx.Products.Remove(product);
                ctx.SaveChanges();

                return Ok(ctx.Products.Include("Category").ToList());


            }
        }

        [Route("removecategory/{id}")]
        [System.Web.Http.AcceptVerbs("GET", "POST", "DELETE")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult RemoveCategory(int id)
        {

            using (var ctx = new ProductEntities())
            {
                var category = ctx.Categorys.FirstOrDefault((x) => x.Id == id);

                ctx.Categorys.Remove(category);
                ctx.SaveChanges();

                return Ok(ctx.Products.Include("Category").ToList());


            }
        }
        [Route("getcategory/{search}")]
        public IHttpActionResult GetCategory(string search)
        {

            using (var ctx = new ProductEntities())
            {
                var category = ctx.Categorys.Where((x) => x.Name.ToLower().Contains(search.ToLower())).ToList();

                if (category != null)
                {
                    return Ok(category);
                }
                else
                {
                    return NotFound();
                }

            }
        }


    }
}
