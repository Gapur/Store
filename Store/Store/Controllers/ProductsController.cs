using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Store.EntityModels;

namespace Store.Controllers
{
    using Managers;
    using Filters;

    [Authorize]
    [Culture]
    public class ProductsController : ApiController
    {
        ProductManager userProductManager = new ProductManager();
        private Entities db = new Entities();

        // GET: api/Products
        [AllowAnonymous]
        public async Task<IHttpActionResult> GetProducts()
        {
            IEnumerable<Models.Product> result;
            try
            {
                result = await userProductManager.GetAllProducts();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // GET: api/Products/5
        [ResponseType(typeof(Models.Product))]
        public async Task<IHttpActionResult> GetProduct(Guid id)
        {
            Models.Product product = await userProductManager.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // GET: api/Products/FilterProducts/
        [HttpGet]
        [Route("Products/{type}/FilterProducts")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> GetFilterProducts(int type)
        {
            IEnumerable<Models.Product> result;
            try
            {
                result = await userProductManager.GetFilterProducts(type);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProduct(Guid id, Models.Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.Id)
            {
                return BadRequest();
            }

            db.Entry(product).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Products
        [ResponseType(typeof(Product))]
        [Authorize(Roles = "admin")]
        public async Task<IHttpActionResult> PostProduct(Models.Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                await userProductManager.CreateProduct(product);
            }
            catch (Exception ex)
            {
                return NotFound();
            }

            return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        [Authorize(Roles = "admin")]
        public async Task<IHttpActionResult> DeleteProduct(Guid id)
        {
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            db.Products.Remove(product);
            await db.SaveChangesAsync();

            return Ok(product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(Guid id)
        {
            return db.Products.Count(e => e.Id == id) > 0;
        }
    }
}