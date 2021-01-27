using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.Models;
using Vega.Persistence;

namespace Vega.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        // GET: api/Features
        [HttpGet("api/features")]
        public IEnumerable<Feature> GetFeatures()
        {
            return context.Features.ToList<Feature>();
        }

        //// GET: api/Features/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetFeature([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var feature = await _context.Feature.FindAsync(id);

        //    if (feature == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(feature);
        //}

        //// PUT: api/Features/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutFeature([FromRoute] int id, [FromBody] Feature feature)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != feature.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(feature).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FeatureExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Features
        //[HttpPost]
        //public async Task<IActionResult> PostFeature([FromBody] Feature feature)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Feature.Add(feature);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetFeature", new { id = feature.Id }, feature);
        //}

        //// DELETE: api/Features/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteFeature([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var feature = await _context.Feature.FindAsync(id);
        //    if (feature == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Feature.Remove(feature);
        //    await _context.SaveChangesAsync();

        //    return Ok(feature);
        //}

        //private bool FeatureExists(int id)
        //{
        //    return _context.Feature.Any(e => e.Id == id);
        //}
    }
}