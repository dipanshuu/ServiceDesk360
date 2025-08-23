using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationProject27July.Models;
using WebApplicationProject27July.Repository;

namespace WebApplicationProject27July.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepositorycs _client;
        public ClientController()
        {
            _client=new ClientRepository();
        }
        // GET: ClientController
        public ActionResult Index()
        {
            List<Client> clnt = _client.GetClients();
            return View(clnt);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            var emp = _client.GetClientById(id);
            return View(emp);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client collection)
        {
            try
            {
                _client.AddClientDetails(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            var client=_client.GetClientById(id);
            return View(client);
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Client collection)
        {
            try
            {
                _client.UpdateClient(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            var clnt=_client.GetClientById(id);
            return View(clnt);
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Client collection)
        {
            try
            {
                _client.DeleteClientDetails(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
