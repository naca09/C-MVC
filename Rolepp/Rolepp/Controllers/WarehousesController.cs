using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rolepp.Data;
using Rolepp.Models;

namespace Rolepp.Controllers
{
    public class WarehousesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarehousesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Warehouses
        public IActionResult Index()
        {
            return View(_context.Warehouses.ToList());
        }

        // GET: Warehouses/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductName,Price,Quantity,ProductCode")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }



        // GET: Warehouses/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouse = _context.Warehouses.Find(id);
            if (warehouse == null)
            {
                return NotFound();
            }
            return View(warehouse);
        }

        // POST: Warehouses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("WarehouseID,WarehouseName,Address")] Warehouse warehouse)
        {
            if (id != warehouse.WarehouseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(warehouse);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(warehouse);
        }

        // GET: Warehouses/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouse = _context.Warehouses.Find(id);
            if (warehouse == null)
            {
                return NotFound();
            }

            return View(warehouse);
        }

        // POST: Warehouses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var warehouse = _context.Warehouses.Find(id);
            _context.Warehouses.Remove(warehouse);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
